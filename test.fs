

z80-internal import
oo import

1024 buffer: ram
variable out_p
variable out_d


: -> [inlined] ;

: read_byte ( usrd adr -- byte )
    ram + c@ swap drop
;

: write_byte ( usrd adr byte -- )
    swap ram + c! drop
;

: port_in ( z80 port -- byte )
    swap drop
;

: port_out ( z80 port byte -- )
    out_d ! out_p ! drop
;

<z80-class> class-size buffer: cpu
' read_byte ' write_byte ' port_in ' port_out <z80-class> cpu init-object

: print_flag ( cpu -- )
    -> f c@ 
    cr ." cnpxhyzs" cr
    8 0 do dup i bit and if [char] 1 else [char] 0 then emit
    loop cr
;

variable fails

: check ( cond )
    if 
        ." pass"
    else
        ." fail"
        1 fails +!
    then cr
;

: test
    0 fails !
    cr
    ." rb : "
        $34 ram ! 0 cpu -> rb $34 = check
    ." wb : "
        1 $56 cpu -> wb ram 1+ c@ $56 = check
    ." rw : " 
        0 cpu -> rw $5634 = check
    ." ww : "
        2 $1234 cpu -> ww ram 2 + h@ $1234 = check
    ." pushw : "
        16 cpu -> sp h! 
        $4321 cpu -> pushw ram 14 + h@ $4321 = cpu -> sp h@ 14 = and check
    ." popw : " cpu -> popw $4321 = cpu -> sp h@ 16 = and check
    ." nextb : " 
        1 cpu -> pc h! cpu -> nextb $56 = cpu -> pc h@ 2 = and check
    ." nextw : " cpu -> nextw $1234 = cpu -> pc h@ 4 = and check
    ." set/get pair : "
        $01 cpu -> set-bc $23 cpu -> set-de $34 cpu -> set-hl
        cpu -> get-hl cpu -> get-de cpu -> get-bc
        $01 = swap $23 = and swap $34 = and check
    ." inc-r : " cpu -> inc-r cpu -> r c@ 1 = check
    ." jump : " 20 cpu -> jump cpu -> pc h@ 20 = check
    ." comd jump: " 30 ram 20 + h! 40 ram 22 + h!
        0 cpu -> cond-jump cpu -> pc h@ 22 =
        1 cpu -> cond-jump cpu -> pc h@ 40 = and check
    ." call : " 20 cpu -> call
        cpu -> pc h@ 20 =   cpu -> sp h@ 14 =  ram 14 + h@ 40 = 
        and and check
    ." cond-call : "
        0 cpu -> cond-call
        cpu -> pc h@ 22 =
        1 cpu -> cond-call
        cpu -> sp h@ 12 = cpu -> pc h@ 40 = ram 12 + h@ 24 = 
        and and and check
    ." ret : " cpu -> ret
        cpu -> pc h@ 24 = cpu -> sp h@ 14 = and check
    ." cond-ret : "
        0 cpu -> cond-ret cpu -> pc h@ 24 =
        1 cpu -> cond-ret cpu -> pc h@ 40 = and check
    ." jr : "
        5 cpu -> jr cpu -> pc h@ 45 = 
        -3 cpu -> jr cpu -> pc h@ 42 = and check
    ." cond-jr : "
        -10 ram 42 + c!
        -4 ram 43 + c! 
        0 cpu -> cond-jr cpu -> pc h@ 43 = 
        1 cpu -> cond-jr cpu -> pc h@ 40 = and check
    ." addb : " 1 2 3 cpu -> addb 4 =
                0 0 0 cpu -> addb 0 = cpu -> f c@ zf and 0> and
                255 1 0 cpu -> addb 0 = cpu -> f c@ cf and 0> and
                                        cpu -> f c@ zf and 0>
                and and and check
    ." subb : "
                123 23 0 cpu -> subb 100 = 
                0 1 0 cpu -> subb 255 = cpu -> f c@ cf and 0> and
                and check
    ." addw : "
                1000 234 0 cpu -> addw 1234 =
                65535 0 1  cpu -> addw 0= cpu -> f c@ cf and 0> and
                and check
    ." subw : " 1234 234 0 cpu -> subw 1000 =
                0 2 0 cpu -> subw 65534 = cpu -> f c@ cf and 0> and
                                          cpu -> f c@ sf and 0> and
                and check
    ." addhl : " zf cpu -> f c!
                0 cpu -> set-hl
                1234 cpu -> addhl
                cpu -> get-hl 1234 = cpu -> f c@ zf and 0> and check
    ." addiz : " 0 cpu -> ix h!
                 cpu -> ix 1234 cpu -> addiz 
                 cpu -> ix h@ 1234 = cpu -> f c@ zf and 0> and check
    ." adchl : " cf cpu -> f c!
                 0 cpu -> set-hl
                 123 cpu -> adchl cpu -> get-hl 124 =
                 65535 cpu -> adchl cpu -> get-hl 123 =
                                    cpu -> f c@ cf and 0> 
                                    and and check
    ." set-flag : " 1 zf cpu -> set-flag
                    1 cf cpu -> set-flag
                    0 cf cpu -> set-flag
                    cpu -> f c@ cf and 0=
                    cpu -> f c@ zf and 0> and check
    ." sbchl : "    cf cpu -> f c!
                    1234 cpu -> set-hl
                    234 cpu -> sbchl
                    cpu -> get-hl 999 = cf cpu -> get-flag 0= and
                    65535 cpu -> sbchl 
                    cpu -> get-hl 1000 = cf cpu -> get-flag and
                    and check
    ." inc : "      1 cf cpu -> set-flag
                    122 cpu -> inc 123 = 
                    cf cpu -> get-flag and check

    ." dec : "      1 cf cpu -> set-flag
                    124 cpu -> dec 123 = 
                    cf cpu -> get-flag and check
    ." land : "     7 cpu -> a c!
                    254 cpu -> land
                    cpu -> a c@ 6 = 
                    pf cpu -> get-flag and check
    ." lxor : "     $07 cpu -> a c!
                    $77 cpu -> lxor
                    cpu -> a c@ $70 = check
    ." lor : "      $07 cpu -> a c!
                    $70 cpu -> lor
                    cpu -> a c@ $77 = check
    ." cp : "       123 cpu -> a c!
                    123 cpu -> cp
                        zf cpu -> get-flag
                    124 cpu -> cp
                        zf cpu -> get-flag 0= cf cpu -> get-flag and 
                    122 cpu -> cp
                        zf cpu -> get-flag 0= 
                        and and check
    ." cb_rlc : "   0 cpu -> f c!
                    7 cpu -> cb_rlc 14 = 
                        cf cpu -> get-flag 0= and
                    129 cpu -> cb_rlc 3 = 
                        cf cpu -> get-flag and 
                        and check

    ." cb_rrc : "   0 cpu -> f c!
                    14 cpu -> cb_rrc 7 = 
                        cf cpu -> get-flag 0= and
                    3 cpu -> cb_rrc 129 = 
                        cf cpu -> get-flag and 
                        and check

    ." cb_rl : "   0 cpu -> f c!
                    7 cpu -> cb_rl 14 = 
                        cf cpu -> get-flag 0= and
                        1 cf cpu -> set-flag
                    129 cpu -> cb_rlc 3 = 
                        cf cpu -> get-flag and 
                        and check

    ." cb_rr : "   0 cpu -> f c!
                    14 cpu -> cb_rr 7 = 
                        cf cpu -> get-flag 0= and
                        1 cf cpu -> set-flag
                    3 cpu -> cb_rr 129 = 
                        cf cpu -> get-flag and 
                        and check

    ." cb_sla : "   0 cpu -> f c!
                    7 cpu -> cb_sla 14 = 
                        cf cpu -> get-flag 0= and
                        1 cf cpu -> set-flag
                    129 cpu -> cb_sla 2 = 
                        cf cpu -> get-flag and 
                        and check
    ." cb_sll : "   0 cpu -> f c!
                    7 cpu -> cb_sll 15 = 
                        cf cpu -> get-flag 0= and
                        1 cf cpu -> set-flag
                    129 cpu -> cb_sll 3 = 
                        cf cpu -> get-flag and 
                        and check
    ." cb_srl : "   0 cpu -> f c!
                    14 cpu -> cb_srl 7 = 
                        cf cpu -> get-flag 0= and
                        1 cf cpu -> set-flag
                    3 cpu -> cb_srl 1 = 
                        cf cpu -> get-flag and 
                        and check
    ." cb_sra : "   14 cpu -> cb_sra 7 =
                        cf cpu -> get-flag 0= and
                    -9 cpu -> cb_sra -5 255 and =
                        cf cpu -> get-flag and 
                        and check
    ." cb_bit : "   $f0 4 cpu -> cb_bit 4 bit =
                        zf cpu -> get-flag 0= and
                    $f0 3 cpu -> cb_bit 0=
                        zf cpu -> get-flag and
                        and check
    ." ldi : "      base ram 100 + 42 move
                    100 cpu -> set-hl
                    200 cpu -> set-de
                    42  cpu -> set-bc
                    begin cpu -> ldi 
                        pf cpu -> get-flag 0= until
                    0 42 0 do ram 100 + i + c@ ram 200 + i + c@ <> if 1+ i . then loop
                    0= check
    ." ldd : "      base ram 100 + 42 move
                    141 cpu -> set-hl
                    241 cpu -> set-de
                    42  cpu -> set-bc
                    begin cpu -> ldd
                        pf cpu -> get-flag 0= until
                    0 42 0 do ram 100 + i + c@ ram 200 + i + c@ <> if 1+ i . then loop
                    0= check
    ." cpi : "      100 cpu -> set-hl
                    5 cpu -> set-bc
                    0 ram 100 + c! $55 ram 101 + c! $60 ram 102 + c!
                    $55 cpu -> a c!
                    cpu -> cpi
                        cpu -> f c@ zf cf or and 0=
                        cpu -> get-hl 101 = and
                        cpu -> get-bc 4 = and
                    cpu -> cpi
                        zf cpu -> get-flag 
                    cpu -> cpi
                    cpu -> cpi
                    cpu -> cpi
                        pf cpu -> get-flag 0=
                    and and check
    ." cpd : "      0 cpu -> f c!
                    102 cpu -> set-hl
                    5 cpu -> set-bc
                    0 ram 100 + c! $55 ram 101 + c! $60 ram 102 + c!
                    $55 cpu -> a c!
                    cpu -> cpd
                        cpu -> f c@ zf cf or and 0=
                        cpu -> get-hl 101 = and
                        cpu -> get-bc 4 = and
                    cpu -> cpd
                        zf cpu -> get-flag 
                    cpu -> cpd
                    cpu -> cpd
                    cpu -> cpd
                        pf cpu -> get-flag 0=
                    and and check
    ." in_r_c : "   123 cpu -> c c!
                    cpu -> a cpu -> in_r_c
                    cpu -> a c@ 123 = 
                    zf cpu -> get-flag 0= and
                    0 cpu -> c c!
                    cpu -> a cpu -> in_r_c
                    cpu -> a c@ 0= 
                    zf cpu -> get-flag and
                    and check
    ." ini : "      50 cpu -> set-hl
                    2 cpu -> b c!
                    123 cpu -> c c!
                    cpu -> ini
                        ram 50 + c@ 123 = 
                        zf cpu -> get-flag 0= and
                    45 cpu -> c c!
                    cpu -> ini
                        ram 51 + c@ 45 =
                        zf cpu -> get-flag and
                    and check
    ." ind : "      51 cpu -> set-hl
                    2 cpu -> b c!
                    67 cpu -> c c!
                    cpu -> ind
                        ram 51 + c@ 67 = 
                        zf cpu -> get-flag 0= and
                    89 cpu -> c c!
                    cpu -> ind
                        ram 50 + c@ 89 =
                        zf cpu -> get-flag and
                    and check
    ." outi : "     50 cpu -> set-hl
                    2 cpu -> b c!
                    123 cpu -> c c!
                    cpu -> outi
                        out_d @ 89 =
                        out_p @ 123 = and
                        zf cpu -> get-flag 0= and
                    cpu -> outi
                        out_d @ 67 =
                        out_p @ 123 = and
                        zf cpu -> get-flag and
                    and check
    ." daa : "      $12 cpu -> a c!
                    hf cpu -> f c!
                    cpu -> daa
                        cpu -> a c@ $18 =
                        cf cpu -> get-flag 0= and
                    $2d cpu -> a c!
                    hf nf or cpu -> f c!
                    cpu -> daa
                        cpu -> a c@ $27 =
                        cf cpu -> get-flag 0= and
                    $ee cpu -> a c!
                    hf cf nf or or cpu -> f c!
                    cpu -> daa
                        cpu -> a c@ $88 =
                        cf cpu -> get-flag and
                    and and check
    ." displace : " 1234 56 cpu -> displace 1234 56 + =
                    1234 -56 $ff and cpu -> displace 1234 56 - = and
                    65535 1 cpu -> displace 0 = and
                    0 255 cpu -> displace 65535 = and 
                    check


                    

                        





    ." ----------------------" cr
    cpu -> debug-output
    ." fails: " fails @ . cr
    ." depth: " depth . cr
;



