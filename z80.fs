\ Based on https://github.com/superzazu/z80

begin-module z80
    begin-module z80-internal
    oo import
    
    : -> [inlined] ;
 
    \ f bits
    7 bit constant sf 
    6 bit constant zf
    5 bit constant yf
    4 bit constant hf
    3 bit constant xf
    2 bit constant pf
    1 bit constant nf
    0 bit constant cf 

    \ state bits
    4 bit constant iff1
    3 bit constant iff2
    2 bit constant halted
    1 bit constant int_pending
    0 bit constant nmi_pending

    create cyc_00 4 c, 10 c, 7 c, 6 c, 4 c, 4 c, 7 c, 4 c, 4 c, 11 c, 7 c, 6 c, 4 c,
    4 c, 7 c, 4 c, 8 c, 10 c, 7 c, 6 c, 4 c, 4 c, 7 c, 4 c, 12 c, 11 c, 7 c, 6 c, 4 c,
    4 c, 7 c, 4 c, 7 c, 10 c, 16 c, 6 c, 4 c, 4 c, 7 c, 4 c, 7 c, 11 c, 16 c, 6 c, 
    4 c, 4 c, 7 c, 4 c, 7 c, 10 c, 13 c, 6 c, 11 c, 11 c, 10 c, 4 c, 7 c, 11 c, 13 c,
    6 c,  4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c,  4 c, 7 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c,  7 c, 4 c, 7 c, 7 c, 7 c, 7 c, 7 c, 7 c, 4 c, 7 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c,  4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c,     4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 7 c, 4 c, 4 c,  4 c, 4 c,
    4 c, 4 c, 4 c, 7 c, 4 c, 5 c, 10 c, 10 c, 10 c, 10 c, 11 c, 7 c, 11 c, 5 c, 10 c, 10 c,
    0 c, 10 c, 17 c, 7 c, 11 c, 5 c, 10 c, 10 c, 11 c, 10 c, 11 c, 7 c, 11 c, 5 c, 4 c, 10 c,
    11 c, 10 c, 0 c, 7 c, 11 c, 5 c, 10 c, 10 c, 19 c, 10 c, 11 c, 7 c, 11 c, 5 c, 4 c, 10 c,
    4 c, 10 c, 0 c, 7 c, 11 c, 5 c, 10 c, 10 c, 4 c, 10 c, 11 c, 7 c, 11 c, 5 c, 6 c,  10 c,
    4 c, 10 c, 0 c, 7 c, 11 c,


    create cyc_ed  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 12 c,  12 c, 15 c, 20 c, 8 c, 14 c, 8 c, 9 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c, 8 c,
    9 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c,  8 c, 9 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c, 8 c,
    9 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c, 8 c, 18 c, 12 c, 12 c, 15 c,  20 c, 8 c, 14 c, 8 c,
    18 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c, 8 c, 8 c, 12 c, 12 c, 15 c, 20 c, 8 c, 14 c, 8 c,
    8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 16 c, 16 c, 16 c, 16 c, 8 c, 8 c, 8 c, 8 c, 16 c, 16 c, 16 c, 16 c, 8 c, 8 c, 8 c,
    8 c,  16 c, 16 c, 16 c, 16 c, 8 c, 8 c, 8 c, 8 c, 16 c, 16 c, 16 c, 16 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,
    8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,  8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,

    create  cyc_ddfd 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 15 c, 4 c, 4 c, 4 c, 4 c,
    4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 15 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4
    c, 4 c, 14 c, 20 c, 10 c, 8 c, 8 c,  11 c, 4 c, 4 c, 15 c, 20 c, 10 c, 8 c, 8 c, 11 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 23 c, 23 c, 19 c, 4 c, 4 c, 15 c, 4 c, 4 c,  4 c, 4 c, 4 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 8 c,  8 c, 19 c, 4 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c, 19 c, 8 c, 8 c, 8 c, 8 c, 8 c, 8 c,  8 c, 19 c, 8
    c, 19 c, 19 c, 19 c, 19 c, 19 c, 19 c, 4 c, 19 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c,  4 c, 8 c, 8 c, 19 c, 4 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4 c, 4 c, 4 c, 4 c,  4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c,  4 c, 8 c, 8 c, 19 c, 4 c, 4 c, 4 c, 4 c, 4 c, 8 c, 8 c, 19 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 0 c,  4 c, 4 c, 4 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4
    c, 4 c, 14 c, 4 c, 23 c, 4 c,  15 c, 4 c, 4 c, 4 c, 8 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4
    c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 4 c, 10 c, 4 c, 4 c, 4 c, 4 c,  4 c, 4 c,

    : GET_BIT ( bit val -- bool_01 )
        [inlined] swap rshift 1 and
    ;
    
    \ returns if there was a carry between bit "bit_no" and "bit_no - 1" when
    \ executing "a + b + cy"
    : carry { bit_no a b cy -- flag }
        cy if 1 else 0 then a b + +
        a xor b xor
        bit_no bit and
        0= 0=
    ;


    \ returns the parity of byte: 0 if number of 1 bits in `val` is odd, else 1
    : parity ( val -- flag)
        0 { nb_one_bits }
        8 0 do
            dup 1 and +to nb_one_bits
            1 rshift
        loop
        drop
        nb_one_bits 1 and 0=
    ;
    
    defer opcodes-table-adr
    defer opcodes-ddfd-table-adr
    defer opcodes-ed-table-adr


    <object> begin-class <z80-class>
        cell member read-byte-cb   ( userdata adr -- byte )
        cell member write-byte-cb  ( userdata adr byte -- )
        cell member port-in-cb     ( z80 port -- byte )
        cell member port-out-cb    ( z80 port byte -- )
        cell member userdata 
        cell member opcodes-table
        cell member opcodes-ddfd-table
        cell member opcodes-ed-table
        cell member iz

        2 cells member cyc         ( cycle count (t-states )
        2 member pc                 ( special registers )
        2 member sp
        2 member ix
        2 member iy
        2 member mem_ptr
        2 member dummy              ( for alignment )
        1 member a 1 member b 1 member c 1 member d 1 member e 1 member h 1 member l
        1 member a_ 1 member b_ 1 member c_ 1 member d_ 1 member e_ 1 member h_ 1 member l_
        1 member f_
        1 member f
        1 member i_
        1 member r
        1 member iff_delay
        1 member interrupt_mode
        1 member int_data
        1 member state

        method z80-init         ( self --   )
        method z80-step         ( self --   )
        method z80-debug-output ( self --   )
        method z80-gen-nmi      ( self --   )
        method z80-gen-int      ( data self --   )
        method rb               ( adr  self --   byte )
        method wb               ( adr  byte self --   )
        method rw               ( adr  self --   word )
        method ww               ( adr  word self --   )
        method pushw            ( val  self --   )
        method popw             (    self --   val  )
        method nextb            ( self --   byte )
        method nextw            ( self --   word )
        method get-bc           ( self --   word )
        method get-de           ( self --   word )
        method get-hl           ( self --   word )
        method set-bc           ( word self --   )
        method set-de           ( word self --   )
        method set-hl           ( word self --   )
        method get-f            ( self --   byte )
        method set-f            ( byte self --   )
        method inc-r            ( self --   )
        method jump             ( adr  self --   )
        method cond-jump        ( cond self --   )
        method call             ( adr  self --   )
        method cond-call        ( cond self --   )
        method ret              (    self --   )
        method cond-ret         ( cond self -- )
        method jr               ( offset self -- )
        method cond-jr          ( cond self  --  )
        method addb             ( a b cy self -- byte )
        method subb             ( a b cy self -- byte )
        method addw             ( a b cy self -- word )
        method subw             ( a b cy self -- word )
        method addhl            ( val self   --  )
        method addiz            ( reg_adr vav self -- )
        method adchl           ( val self -- ) 
        method set-flag         ( bool flag self -- )
        method get-flag         ( flag self -- bool )
        method sbchl            ( val self -- )
        method inc              ( val self -- byte )
        method dec              ( val self -- byte )
        method land             ( val self -- )
        method lxor             ( val self -- )
        method lor              ( val self -- )
        method cp               ( val self -- )
        method cb_rlc           ( val self -- byte )
        method cb_rrc           ( val self -- byte )
        method cb_rl            ( val self -- byte )
        method cb_rr            ( val self -- byte )
        method cb_sla           ( val self -- byte )
        method cb_sll           ( val self -- byte )
        method cb_sra           ( val self -- byte )
        method cb_srl           ( val self -- byte )
        method cb_bit           ( val n self -- byte )
        method ldi              (   self   -- )
        method ldd              (   self   -- )
        method cpi              (   self   -- )
        method cpd              (   self   -- )
        method port-in          ( port self -- byte)
        method port-out         ( port val self -- )
        method in_r_c           ( reg_adr self )
        method ini              ( self -- )
        method ind              ( self -- )
        method outi             ( self -- )
        method outd             ( self -- )
        method daa              ( self -- )
        method displace         ( adr16 offset8 self -- newadr )
        method process-interrupts ( self -- )
        method exec-opcode      ( opcode self -- )
        method step             ( self -- )
        method debug-output     ( self -- )
        method gen-nmi          ( self -- )
        method gen-int          ( data self -- )
        method exec-opcode-cb   ( opcode self -- )
        method exec-opcode-ed   ( opcode self )
        method exec-opcode-ddfd ( opcode self )
        method exec-opcode-dcb  ( op adr self -- )

        

    end-class


    <z80-class> begin-implement
        :noname  { read_cb write_cb in_cb out_cb self }
            0 self -> read-byte-cb  ! ( userdata adr -- byte )
            0 self -> write-byte-cb ! ( userdata adr byte -- )
            0 self -> port-in-cb    ! ( z80 port -- byte )
            0 self -> port-out-cb   ! ( z80 port byte -- )
            0 self -> userdata      !
            0. self -> cyc       2!  ( cycle count (t-states )
            0 self -> pc        h!         ( special registers )
            $FFFF self -> sp        h!
            0 self -> ix        h!
            0 self -> iy        h!
            0 self -> mem_ptr   h!
            0 self -> dummy     h!         ( for alignment )
            $ff self -> a c! 0 self -> b c! 0 self -> c c! 0 self -> d c! 
            0 self -> e c! 0 self -> h c! 0 self -> l c!
            0 self -> a_ c! 0 self -> b_ c! 0 self -> c_ c! 0 self -> d_ c! 
            0 self -> e_ c! 0 self -> h_ c! 0 self -> l_ c!
            0 self -> f_ c!
            $ff self -> f  c!
            0 self -> i_ c!
            0 self -> r  c!
            0 self -> iff_delay c!
            0 self -> interrupt_mode c!
            0 self -> int_data c!
            0 self -> state c!
            read_cb self -> read-byte-cb !   ( userdata adr -- byte )
            write_cb self -> write-byte-cb ! ( userdata adr byte -- )
            in_cb self -> port-in-cb  !      ( z80 port -- byte )
            out_cb self -> port-out-cb !     ( z80 port byte -- )
            opcodes-table-adr self -> opcodes-table !
            opcodes-ddfd-table-adr self -> opcodes-ddfd-table !
            opcodes-ed-table-adr self -> opcodes-ed-table !
        ; define new

        :noname { adr self -- byte } [inlined]
            self -> userdata @ adr self -> read-byte-cb @ execute
        ; define rb

        :noname { adr byte self -- } [inlined]

            self -> userdata @ adr byte self -> write-byte-cb @ execute
        ; define wb

        :noname { adr self -- word } [inlined]

            self -> userdata @ adr self -> read-byte-cb @ execute
            self -> userdata @ adr 1+ self -> read-byte-cb  @ execute
            8 lshift or
        ; define rw

        :noname { adr val self -- } [inlined]

            self -> userdata @ adr val 255 and self -> write-byte-cb @ execute
            self -> userdata @ adr 1+ val 8 rshift self -> write-byte-cb @ execute
        ; define ww

        :noname { val self -- } [inlined]

            -2 self -> sp h+!
            self -> sp h@ val self -> ww 
        ; define pushw

        :noname { self -- val } [inlined]
            self -> sp h@ self -> rw
            2 self -> sp h+!
        ; define popw

        :noname { self -- byte } [inlined]
            self -> pc h@ self -> rb
            1 self -> pc h+!
        ; define nextb
        
        :noname { self -- word } [inlined]
            self -> pc h@ self -> rw
            2 self -> pc h+!
        ; define nextw


        :noname { self } [inlined]
            self -> b c@ 8 lshift self -> c c@ or
        ; define  get-bc ( self -- word )

        :noname { self } [inlined]
            self -> d c@ 8 lshift self -> e c@ or
        ; define  get-de ( self -- word )
        
        :noname { self } [inlined]
            self -> h c@ 8 lshift self -> l c@ or
        ; define  get-hl ( self -- word )

        :noname { val self } [inlined]
            val 8 rshift self -> b c!
            val 255 and  self -> c c!
        ; define  set-bc ( val self -- )

        :noname { val self } [inlined]
            val 8 rshift self -> d c!
            val 255 and  self -> e c!
        ; define  set-de ( val self --  )

        :noname { val self } [inlined]
            val 8 rshift self -> h c!
            val 255 and  self -> l c!
        ; define  set-hl ( val self --  )

        :noname { self } [inlined]
            self -> f c@
        ; define get-f
        
        :noname { byte self -- } [inlined]
            byte self -> f c!
        ; define set-f

        \ increments R, keeping the highest byte intact
        :noname { self } [inlined]
            self -> r c@ $80 and self -> r c@ 1+ $7f and or self -> r c!
        ; define inc-r
        
        :noname { adr self -- } [inlined]
            adr self -> pc h!
            adr self -> mem_ptr h!
        ; define jump

        :noname { cond self -- } [inlined]
            self -> nextw { adr }
            cond if
                adr self -> jump
            then
            adr self -> mem_ptr h!
        ; define cond-jump

        :noname { adr self -- } [inlined]
            self -> pc h@ self -> pushw
            adr self -> pc h!
            adr self -> mem_ptr h!
        ; define call
        
        :noname { cond self } [inlined]
            self -> nextw { adr }
            cond if
                adr self -> call
                7. self -> cyc 2+!
            then
            adr self -> mem_ptr h!
        ; define cond-call

        :noname { self -- } [inlined]
            self -> popw dup self -> pc h!
            self -> mem_ptr h!
        ; define ret

        :noname { cond self } [inlined]
            cond if
                self -> ret
                6. self -> cyc 2+!
            then
        ; define cond-ret

        :noname { offset self } [inlined]
            offset $7f and offset $80 and if -128 + then
            self -> pc h+!
            self -> pc h@ self -> mem_ptr h!
        ; define jr
        
        :noname { cond self } [inlined]
            self -> nextb
            cond if
                self -> jr
                5.  self -> cyc 2+!
            else
                drop
            then
        ; define cond-jr
        
        :noname { a b cy self -- byte }
            cy if 1 else 0 then a + b + 255 and
            0
            over $80 and         if sf or then
            over 0=              if zf or then
            4 a b cy carry       if hf or then
            7 a b cy carry 8 a b cy carry <> if pf or then
            8 a b cy carry      if  cf or then
            over 3 swap GET_BIT       if xf or then
            over 5 swap GET_BIT       if yf or then
            self -> f c!
        ; define addb

        :noname { a b cy self -- byte } [inlined]
            a b 255 xor cy 0= self -> addb
            self -> f c@ cf hf or xor nf or self -> f c!
        ; define subb

        :noname { a b cy self -- byte } [inlined]
            a 255 and b 255 and cy self -> addb
            a 8 rshift b 8 rshift self -> f c@ cf and self -> addb
            8 lshift or dup
            0= if self -> f c@ zf or self -> f c! then
            a 1+ self -> mem_ptr h!
        ; define addw

        :noname { a b cy self -- word } [inlined]
            a 255 and  b 255 and  cy self -> subb
            a 8 rshift b 8 rshift self f c@ cf and self -> subb
            8 lshift or dup
            0= if self -> f c@ zf or self -> f c! then
            a 1+ self -> mem_ptr h!
        ; define subw
        
        :noname { val self -- } [inlined]
            self -> f c@ sf zf pf or or and { t_flg }
            self -> get-hl val 0 self -> addw
            self -> set-hl
            self -> f c@ sf zf pf or or 255 xor and t_flg or self -> f c!
        ; define addhl

        :noname { reg_adr val self -- } [inlined]
            self -> f c@ sf zf pf or or and { t_flg }
            reg_adr h@ val 0 self -> addw reg_adr h!
            self -> f c@ sf zf pf or or 255 xor and t_flg or self -> f c!
        ; define addiz

        :noname { val self -- } [inlined]
            self -> get-hl val self -> f c@ cf and self -> addw
            dup 15 rshift sf self -> set-flag
            dup 0= zf self -> set-flag
            self -> set-hl
        ; define adchl

        :noname { val flag self -- } [inlined]
            val if
                self -> f c@ flag or
            else
                self -> f c@ flag 255 xor and
            then
            self -> f c!
        ; define set-flag

        :noname { val self -- } [inlined]
            self -> get-hl val self -> f c@ cf and self -> subw
            dup 15 rshift sf self -> set-flag
            dup 0= zf self -> set-flag
            self -> set-hl
        ; define sbchl

        :noname { val self -- byte } [inlined]
           cf self -> get-flag
           val 1 0 self -> addb
           swap cf self -> set-flag
        ; define inc
        
        :noname { flag self -- bool } [inlined]
            self -> f c@ flag and 0>
        ; define get-flag

        :noname { val self -- byte } [inlined]
           cf self -> get-flag
           val 1 0 self -> subb
           swap cf self -> set-flag
        ; define dec

        :noname { val self -- } [inlined]
            self -> a c@ val and
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            hf or
            over parity   if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
            self -> a c!
        ; define land

        :noname { val self -- } [inlined]
            self -> a c@ val xor
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
            self -> a c!
        ; define lxor
        
        :noname { val self -- } [inlined]
            self -> a c@ val or
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
            self -> a c!
        ; define lor
        
        :noname { val self -- } [inlined]
            self -> a c@ val 0 self -> subb drop
            5 val GET_BIT yf self -> set-flag
            3 val GET_BIT xf self -> set-flag
        ; define cp

         :noname { val self -- byte } [inlined]
            val 7 rshift 1 and 
            dup val 1 lshift or 255 and
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            2 pick        if cf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
            swap drop
        ; define cb_rlc
        
        :noname { val self -- byte } [inlined]
            val 1 and 
            dup 7 lshift val 1 rshift or 255 and
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            2 pick        if cf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
            swap drop
        ; define cb_rrc
        
        :noname { val self -- byte } [inlined]
            cf self -> get-flag if 1 else 0 then
            val 1 lshift or 255 and
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            val 7 rshift  if cf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
        ; define cb_rl

        :noname { val self -- byte } [inlined]
            cf self -> get-flag if $80 else 0 then
            val 1 rshift or 255 and
            0
            over 7 rshift if sf or then
            over 0=       if zf or then
            over parity   if pf or then
            val 1 and     if cf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c!
        ; define cb_rr
        
        :noname { val self -- byte } [inlined]
            val 1 lshift 255 and
            0
            val $80 and if cf or then
            over $80 and if sf or then
            over 0=     if zf or then
            over parity if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c! 
        ; define cb_sla
        
        :noname { val self -- byte } [inlined]
            val 1 lshift 255 and 1 or
            0
            val $80 and if cf or then
            over $80 and if sf or then
            over 0=     if zf or then
            over parity if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c! 
        ; define cb_sll

        :noname { val self -- byte } [inlined]
            val 1 rshift val $80 and or 255 and 
            0
            val $1 and if cf or then
            over $80 and if sf or then
            over 0=     if zf or then
            over parity if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c! 
        ; define cb_sra

        :noname { val self -- byte } [inlined]
            val 1 rshift 255 and
            0
            val $1 and if cf or then
            over $80 and if sf or then
            over 0=     if zf or then
            over parity if pf or then
            over 3 swap GET_BIT if xf or then
            over 5 swap GET_BIT if yf or then
            self -> f c! 
        ; define cb_srl

        :noname { val n self -- byte } [inlined]
            val n bit and
            self -> f c@ cf and
            over $80 and if sf or then
            over 0=     if zf or pf or then
            val 3 swap GET_BIT if xf or then
            val 5 swap GET_BIT if yf or then
            hf  or
            self -> f c!
        ; define cb_bit

        :noname { self } [inlined]
            self -> get-hl self -> rb dup
            self -> get-de
            swap self -> wb
            self -> get-hl 1+ self -> set-hl
            self -> get-de 1+ self -> set-de
            self -> get-bc 1- self -> set-bc
            self -> a c@ + 255 and
            self -> f c@ sf cf zf or or and
            over 3 swap GET_BIT if xf or then
            over 1 swap GET_BIT if yf or then
            self -> get-bc 0> if pf or then
            self -> f c!
            drop
        ; define ldi

        :noname { self } [inlined]
            self -> ldi
            self -> get-hl 2 - self -> set-hl
            self -> get-de 2 - self -> set-de
        ; define ldd
        
        :noname { self } [inlined]
            self -> f c@ cf and { _cf_ }
            self -> a c@ self -> get-hl self -> rb 0 self -> subb { a-hl }
            self -> f c@ xf yf pf cf or or or 255 xor and
            self -> get-hl 1+ self -> set-hl
            self -> get-bc 1- self -> set-bc
            hf self -> get-flag if  -1 +to a-hl then
            3 a-hl GET_BIT if xf or then
            1 a-hl GET_BIT if yf or then
            self -> get-bc 0> if pf or then
            _cf_ if cf or then
            1 self -> mem_ptr h+!
            self -> f c!
        ; define cpi

        :noname { self } [inlined]
            self -> cpi
            self -> get-hl 2 - self -> set-hl
            -2 self -> mem_ptr h+!
        ; define cpd

        :noname { port self -- byte } [inlined]
            self port self -> port-in-cb @ execute
        ; define port-in

        :noname { port val self -- } [inlined]
            self port val self -> port-out-cb @ execute
            self -> get-bc 1+ self -> mem_ptr h!
        ; define port-out

        :noname { reg_adr self --  } [inlined]
            self -> c c@ self -> port-in reg_adr c!
            reg_adr c@ 0= zf      self -> set-flag
            reg_adr c@ $80 and sf self -> set-flag
            reg_adr c@ parity pf  self -> set-flag
            0 nf                  self -> set-flag
            0 hf                  self -> set-flag
            self -> get-bc 1+ self -> mem_ptr h!
        ; define in_r_c
        
        :noname { self -- } [inlined]
            self -> c c@ self -> port-in
            self -> get-hl swap self -> wb
            self -> get-hl 1+ self -> set-hl
            -1 self -> b c+!
            self -> b c@ 0= zf self -> set-flag
            1 nf self -> set-flag
            self -> get-bc 1+ self -> mem_ptr h!
        ; define ini

        :noname { self -- } [inlined]
            self -> ini
            self -> get-hl 2 - self -> set-hl
            self -> get-bc 2 - self -> mem_ptr h!
        ; define ind

        :noname { self } [inlined]
            self -> c c@ self -> get-hl self -> rb self -> port-out
            self -> get-hl 1+ self -> set-hl
            -1 self -> b c+!
            self -> b c@ 0= zf self -> set-flag
            1 nf self -> set-flag
            self get-bc 1+ self -> mem_ptr h!
        ; define outi

        :noname { self }
            self -> outi
            self -> get-hl 2 - self -> set-hl
            self -> get-bc 2 - self -> mem_ptr h!
        ; define outd

        :noname { self -- }
            0 0 { correction substraction }
            self -> a c@ $0F and $09 > 
            hf self -> get-flag or if
                $06 +to correction
            then
            self -> a c@ $99 > cf self -> get-flag or if
                $60 +to correction
                1 cf self -> set-flag
            then
            nf self -> get-flag if
                self -> a c@ $0F and $06 <
                hf self -> get-flag and      hf self -> set-flag
                correction negate self -> a c+! 
            else
                self -> a c@ $0F and $09 > hf self -> set-flag
                correction self -> a c+!
            then
            self -> a c@
            dup $80 and sf self -> set-flag
            dup 0=      zf self -> set-flag
            dup parity  pf self -> set-flag
            3 over GET_BIT xf self -> set-flag
            5 over GET_BIT yf self -> set-flag
            drop
        ; define daa
        
        :noname { adr16 offset8 self -- newadr }
            offset8 $7f and offset8 $80 and if -128 + then adr16 + $ffff and
            dup self -> mem_ptr h!
        ; define displace
        
        :noname { self }
            self -> iff_delay c@ 0> if
                -1 self -> iff_delay c+!
                self -> iff_delay c@ 0= if
                    self -> state c@ iff1 iff2 or or self -> state c!
                then
                exit
            then
            self -> state c@ nmi_pending and if
                self -> state c@ nmi_pending halted iff1 or or 255 xor and self -> state c!
                self -> inc-r
                11. self -> cyc 2+!
                $66 self -> call
                exit
            then
            self -> state c@ int_pending and 0>
            self -> state c@ iff1 and 0> and if
                self -> state c@ int_pending halted iff1 iff2 or or or 255 xor and
                self -> state c!
                self -> inc-r
                self -> interrupt_mode c@ case
                    0 of
                        11. self -> cyc 2+!
                        self -> int_data c@ self -> exec-opcode
                    endof
                    1 of
                        13. self -> cyc 2+!
                        $38 self -> call
                    endof
                    2 of
                        19. self -> cyc 2+!
                        self -> i_  8 lshift self -> int_data c@ or self -> rw self -> call
                    endof
                    ." Z80: Unsupported interrupt mode  " self -> interrupt_mode . cr
                endcase
            then
        ; define process-interrupts
        
        :noname { self -- }
            self -> state c@ halted and if
                $00 self -> exec-opcode
            else
                self -> nextb self -> exec-opcode
            then
            self -> process-interrupts
        ; define step

        :noname { self -- }
            ." PC:" self -> pc h@ h.4 space
            ." AF:" self -> a c@ 8 lshift self -> f c@ or h.4 space
            ." BC:" self -> get-bc h.4 space
            ." DE:" self -> get-de h.4 space
            ." HL:" self -> get-hl h.4 space
            ." SP:" self -> sp h@ h.4 space
            ." IX:" self -> ix h@ h.4 space
            ." IY:" self -> iy h@ h.4 space
            ." I:" self -> i_ c@ h.2 space
            ." R:" self -> r c@ h.2 space
            ." ("
                    self -> pc h@  self -> rb h.2 space
                    self -> pc h@ 1+ self -> rb h.2 space
                    self -> pc h@ 2 + self -> rb h.2 space
                    self -> pc h@ 3 + self -> rb h.2 space
            ." ), cyc: " self -> cyc 2@ d.
            depth .
            cr
        ; define debug-output

        :noname { self }
            self -> state c@ nmi_pending or self -> state c!
        ; define gen-nmi

        :noname { data self }
            self -> state c@ int_pending or self -> state c!
            data self -> int_data c!
        ; define gen-int
        
        :noname { opcode z }
            cyc_00 opcode + c@ s>d z -> cyc 2+!
            z -> inc-r
            z z -> opcodes-table @ opcode cells + @ execute
        ; define exec-opcode
        
        :noname { opcode self }
           cyc_ddfd opcode + c@ s>d self -> cyc 2+!
           self -> inc-r
           self self -> opcodes-ddfd-table @ opcode cells + @ execute
        ; define exec-opcode-ddfd

        :noname { opcode z }
            8. z -> cyc 2+!
            z -> inc-r
            opcode 6 rshift 3 and { _x_ }
            opcode 3 rshift 7 and { _y_ }
            opcode 7 and          { _z_ }
            z -> dummy            { _hl_ }
            0                     { _reg_ }

            _z_ case
                0 of z -> b to _reg_ endof
                1 of z -> c to _reg_ endof
                2 of z -> d to _reg_ endof
                3 of z -> e to _reg_ endof
                4 of z -> h to _reg_ endof
                5 of z -> l to _reg_ endof
                6 of z -> get-hl z -> rb _hl_ c! _hl_ to _reg_ endof
                7 of z -> a to _reg_ endof
            endcase

            _x_ case
                0 of
                    _y_ case
                        0 of _reg_ c@ z -> cb_rlc _reg_ c! endof
                        1 of _reg_ c@ z -> cb_rrc _reg_ c! endof
                        2 of _reg_ c@ z -> cb_rl  _reg_ c! endof
                        3 of _reg_ c@ z -> cb_rr  _reg_ c! endof
                        4 of _reg_ c@ z -> cb_sla  _reg_ c! endof
                        5 of _reg_ c@ z -> cb_sra  _reg_ c! endof
                        6 of _reg_ c@ z -> cb_sll  _reg_ c! endof
                        7 of _reg_ c@ z -> cb_srl  _reg_ c! endof
                    endcase
                endof
                1 of
                    _reg_ c@ _y_ z -> cb_bit drop
                    _z_ 6 = if
                        z -> f c@ xf yf or 255 xor and
                        5 z -> mem_ptr h@ 8 rshift GET_BIT if yf or then
                        3 z -> mem_ptr h@ 8 rshift GET_BIT if xf or then
                        z -> f c!
                        4. z -> cyc 2+!
                    then
                endof
                2 of  _y_ bit 255 xor _reg_ c@ and _reg_ c! endof
                3 of  _y_ bit _reg_ c@ or _reg_ c! endof
            endcase

            _x_ 0= _x_ 2 = or _x_ 3 = or _z_ 6 = and if 7. z -> cyc 2+! then
            _reg_ _hl_ =  _x_ 1 <> and if z -> get-hl _hl_ c@ z -> wb then

        ; define exec-opcode-cb

        :noname { opcode adr z }
            adr z -> rb { val }
            0 { result }
            opcode 6 rshift 3 and   { _x_ }
            opcode 3 rshift 7 and   { _y_ }
            opcode 7 and            { _z_ }

            _x_ case
                0 of
                   _y_ case
                        0 of val z -> cb_rlc to result endof
                        1 of val z -> cb_rrc to result endof
                        2 of val z -> cb_rl to result endof
                        3 of val z -> cb_rr to result endof
                        4 of val z -> cb_sla to result endof
                        5 of val z -> cb_sra to result endof
                        6 of val z -> cb_sll to result endof
                        7 of val z -> cb_srl to result endof
                   endcase
                endof
                1 of    \ bit y,(iz+d)
                    val _y_ z -> cb_bit  to result
                    5 adr 8 rshift GET_BIT yf z -> set-flag
                    3 adr 8 rshift GET_BIT xf z -> set-flag
                endof
                2 of _y_ bit 255 xor val and to result endof  \ res y,(iz+d)
                3 of _y_ bit  val or to result endof         \ set y,(iz+d)
            endcase

              \ ld r[z], rot[y] (iz+d)
              \ ld r[z], res y,(iz+d)
              \ ld r[z], set y,(iz+d)
            _x_ 1 <> _z_ 6 <> and if
                _z_ case
                    0 of result z -> b c! endof
                    1 of result z -> c c! endof
                    2 of result z -> d c! endof
                    3 of result z -> e c! endof
                    4 of result z -> h c! endof
                    5 of result z -> l c! endof
                    6 of z -> get-hl result z -> wb endof
                    7 of result z -> a c! endof
                endcase
            then

            _x_ 1 = if
                20. z -> cyc 2+!
            else
                adr result z -> wb
                23. z -> cyc 2+!
            then

        ; define exec-opcode-dcb
   
        :noname { opcode z }
            cyc_ed opcode + c@ s>d z -> cyc 2+!
            z -> inc-r
            z z -> opcodes-ed-table @ opcode cells + @ execute
        ; define exec-opcode-ed

    

    end-implement
        
        ram-here
        256 cells ram-allot
        constant opcodes-table-buffer

        :noname { z } ." Unimplemented instruction:" z -> pc h@  -1 z -> rb h.2 cr ;
        256 0 do dup opcodes-table-buffer i cells + ! loop drop

        : opcode-add { opcode exec }
            exec opcodes-table-buffer opcode cells + !
        ;

        : gen-opcodes-table
               $7F [: { z } z -> a c@ z -> a c! ;] opcode-add \ ld a,a
               $78 [: { z } z -> b c@ z -> a c! ;] opcode-add \ ld a,b
               $79 [: { z } z -> c c@ z -> a c! ;] opcode-add \ ld a,c
               $7A [: { z } z -> d c@ z -> a c! ;] opcode-add \ ld a,d
               $7B [: { z } z -> e c@ z -> a c! ;] opcode-add \ ld a,e
               $7C [: { z } z -> h c@ z -> a c! ;] opcode-add \ ld a,h
               $7D [: { z } z -> l c@ z -> a c! ;] opcode-add \ ld a,l

               $47 [: { z } z -> a c@ z -> b c! ;] opcode-add \ ld b,a
               $40 [: { z } z -> b c@ z -> b c! ;] opcode-add \ ld b,b
               $41 [: { z } z -> c c@ z -> b c! ;] opcode-add \ ld b,c
               $42 [: { z } z -> d c@ z -> b c! ;] opcode-add \ ld b,d
               $43 [: { z } z -> e c@ z -> b c! ;] opcode-add \ ld b,e
               $44 [: { z } z -> h c@ z -> b c! ;] opcode-add \ ld b,h
               $45 [: { z } z -> l c@ z -> b c! ;] opcode-add \ ld b,l

               $4F [: { z } z -> a c@ z -> c c! ;] opcode-add \ ld c,a
               $48 [: { z } z -> b c@ z -> c c! ;] opcode-add \ ld c,b
               $49 [: { z } z -> c c@ z -> c c! ;] opcode-add \ ld c,c
               $4A [: { z } z -> d c@ z -> c c! ;] opcode-add \ ld c,d
               $4B [: { z } z -> e c@ z -> c c! ;] opcode-add \ ld c,e
               $4C [: { z } z -> h c@ z -> c c! ;] opcode-add \ ld c,h
               $4D [: { z } z -> l c@ z -> c c! ;] opcode-add \ ld c,l

               $57 [: { z } z -> a c@ z -> d c! ;] opcode-add \ ld d,a
               $50 [: { z } z -> b c@ z -> d c! ;] opcode-add \ ld d,b
               $51 [: { z } z -> c c@ z -> d c! ;] opcode-add \ ld d,c
               $52 [: { z } z -> d c@ z -> d c! ;] opcode-add \ ld d,d
               $53 [: { z } z -> e c@ z -> d c! ;] opcode-add \ ld d,e
               $54 [: { z } z -> h c@ z -> d c! ;] opcode-add \ ld d,h
               $55 [: { z } z -> l c@ z -> d c! ;] opcode-add \ ld d,l

               $5F [: { z } z -> a c@ z -> e c! ;] opcode-add \ ld e,a
               $58 [: { z } z -> b c@ z -> e c! ;] opcode-add \ ld e,b
               $59 [: { z } z -> c c@ z -> e c! ;] opcode-add \ ld e,c
               $5A [: { z } z -> d c@ z -> e c! ;] opcode-add \ ld e,d
               $5B [: { z } z -> e c@ z -> e c! ;] opcode-add \ ld e,e
               $5C [: { z } z -> h c@ z -> e c! ;] opcode-add \ ld e,h
               $5D [: { z } z -> l c@ z -> e c! ;] opcode-add \ ld e,l

               $67 [: { z } z -> a c@ z -> h c! ;] opcode-add \ ld h,a
               $60 [: { z } z -> b c@ z -> h c! ;] opcode-add \ ld h,b
               $61 [: { z } z -> c c@ z -> h c! ;] opcode-add \ ld h,c
               $62 [: { z } z -> d c@ z -> h c! ;] opcode-add \ ld h,d
               $63 [: { z } z -> e c@ z -> h c! ;] opcode-add \ ld h,e
               $64 [: { z } z -> h c@ z -> h c! ;] opcode-add \ ld h,h
               $65 [: { z } z -> l c@ z -> h c! ;] opcode-add \ ld h,l

               $6F [: { z } z -> a c@ z -> l c! ;] opcode-add \ ld l,a
               $68 [: { z } z -> b c@ z -> l c! ;] opcode-add \ ld l,b
               $69 [: { z } z -> c c@ z -> l c! ;] opcode-add \ ld l,c
               $6A [: { z } z -> d c@ z -> l c! ;] opcode-add \ ld l,d
               $6B [: { z } z -> e c@ z -> l c! ;] opcode-add \ ld l,e
               $6C [: { z } z -> h c@ z -> l c! ;] opcode-add \ ld l,h
               $6D [: { z } z -> l c@ z -> l c! ;] opcode-add \ ld l,l

               $7E [: { z } z -> get-hl z -> rb z -> a c! ;] opcode-add \ ld a,(hl)
               $46 [: { z } z -> get-hl z -> rb z -> b c! ;] opcode-add \ ld b,(hl)
               $4E [: { z } z -> get-hl z -> rb z -> c c! ;] opcode-add \ ld c,(hl)
               $56 [: { z } z -> get-hl z -> rb z -> d c! ;] opcode-add \ ld d,(hl)
               $5E [: { z } z -> get-hl z -> rb z -> e c! ;] opcode-add \ ld e,(hl)
               $66 [: { z } z -> get-hl z -> rb z -> h c! ;] opcode-add \ ld h,(hl)
               $6E [: { z } z -> get-hl z -> rb z -> l c! ;] opcode-add \ ld l,(hl)

               $77 [: { z } z -> get-hl z -> a c@ z -> wb ;] opcode-add \ ld (hl),a
               $70 [: { z } z -> get-hl z -> b c@ z -> wb ;] opcode-add \ ld (hl),b
               $71 [: { z } z -> get-hl z -> c c@ z -> wb ;] opcode-add \ ld (hl),c
               $72 [: { z } z -> get-hl z -> d c@ z -> wb ;] opcode-add \ ld (hl),d
               $73 [: { z } z -> get-hl z -> e c@ z -> wb ;] opcode-add \ ld (hl),e
               $74 [: { z } z -> get-hl z -> h c@ z -> wb ;] opcode-add \ ld (hl),h
               $75 [: { z } z -> get-hl z -> l c@ z -> wb ;] opcode-add \ ld (hl),l

               $3E [: { z } z -> nextb z -> a c! ;] opcode-add \ ld a,*
               $06 [: { z } z -> nextb z -> b c! ;] opcode-add \ ld b,*
               $0E [: { z } z -> nextb z -> c c! ;] opcode-add \ ld c,*
               $16 [: { z } z -> nextb z -> d c! ;] opcode-add \ ld d,*
               $1E [: { z } z -> nextb z -> e c! ;] opcode-add \ ld e,*
               $26 [: { z } z -> nextb z -> h c! ;] opcode-add \ ld h,*
               $2E [: { z } z -> nextb z -> l c! ;] opcode-add \ ld l,*
               $36 [: { z } z -> get-hl z -> nextb z -> wb ;] opcode-add \ ld (hl),*
               $0A [: { z }
                    z -> get-bc z -> rb z -> a c!
                    z -> get-bc 1+ z -> mem_ptr h!
                ;] opcode-add \ ld a,(bc)
               $1A [: { z }
                    z -> get-de z -> rb z -> a c!
                    z -> get-de 1+ z -> mem_ptr h!
                ;] opcode-add \ ld a,(de)
               $3A [: { z } 
                    z -> nextw
                    dup z -> rb z -> a c!
                    1+ z -> mem_ptr h!
                ;] opcode-add \ ld a,(**)

               $02 [: { z }
                    z -> get-bc z -> a c@ z -> wb
                    z -> a c@ 8 lshift z -> get-bc 1+ 255 and or z -> mem_ptr h!
                ;] opcode-add \ ld (bc),a

               $12 [: { z }
                    z -> get-de z -> a c@ z -> wb
                    z -> a c@ 8 lshift z -> get-de 1+ 255 and or z -> mem_ptr h!
                ;] opcode-add \ ld (de),a

               $32 [: { z } 
                    z -> nextw
                    dup z -> a c@ z -> wb
                    1+ 255 and z -> a c@ 8 lshift or z -> mem_ptr h!
               ;] opcode-add \ ld (**),a

               $01 [: { z } z -> nextw z -> set-bc ;] opcode-add \ ld bc,** 
               $11 [: { z } z -> nextw z -> set-de ;] opcode-add \ ld de,** 
               $21 [: { z } z -> nextw z -> set-hl ;] opcode-add \ ld hl,**
               $31 [: { z } z -> nextw z -> sp h! ;] opcode-add \ ld sp,** 

               $2A [: { z }
                    z -> nextw
                    dup z -> rw z -> set-hl
                    1+ z -> mem_ptr h!
               ;] opcode-add \ ld hl,(**)
               $22 [: { z }
                    z -> nextw
                    dup z -> get-hl z -> ww
                    1+ z -> mem_ptr h!
               ;] opcode-add \ ld (**),hl
               
               $f9 [: { z } z -> get-hl z -> sp h! ;] opcode-add \ ld sp,hl

               $eb [: { z } z -> get-hl z -> get-de z -> set-hl z -> set-de ;] opcode-add \ ex de,hl
               $e3 [: { z } 
                    z -> sp h@ z -> rw
                    z -> sp h@ z -> get-hl z -> ww
                    dup z -> set-hl
                    z -> mem_ptr h!
               ;] opcode-add \ ex (sp),hl

               $87 [: { z } z -> a c@ z -> a c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,a
               $80 [: { z } z -> a c@ z -> b c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,b
               $81 [: { z } z -> a c@ z -> c c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,c
               $82 [: { z } z -> a c@ z -> d c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,d
               $83 [: { z } z -> a c@ z -> e c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,e
               $84 [: { z } z -> a c@ z -> h c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,h
               $85 [: { z } z -> a c@ z -> l c@ 0 z -> addb z -> a c! ;] opcode-add \ add a,l
               $86 [: { z } z -> a c@ z -> get-hl z -> rb 0 z -> addb z -> a c! ;] opcode-add \ add a,(hl)
               $C6 [: { z } z -> a c@ z -> nextb 0 z -> addb z -> a c! ;] opcode-add \ add a,*

               $8f [: { z } z -> a c@ z -> a c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,a
               $88 [: { z } z -> a c@ z -> b c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,b
               $89 [: { z } z -> a c@ z -> c c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,c
               $8a [: { z } z -> a c@ z -> d c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,d
               $8b [: { z } z -> a c@ z -> e c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,e
               $8c [: { z } z -> a c@ z -> h c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,h
               $8d [: { z } z -> a c@ z -> l c@ cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,l
               $8e [: { z } z -> a c@ z -> get-hl z -> rb cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,(hl)
               $Ce [: { z } z -> a c@ z -> nextb cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a,*

               $97 [: { z } z -> a c@ z -> a c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,a
               $90 [: { z } z -> a c@ z -> b c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,b
               $91 [: { z } z -> a c@ z -> c c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,c
               $92 [: { z } z -> a c@ z -> d c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,d
               $93 [: { z } z -> a c@ z -> e c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,e
               $94 [: { z } z -> a c@ z -> h c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,h
               $95 [: { z } z -> a c@ z -> l c@ 0 z -> subb z -> a c! ;] opcode-add \ sub a,l
               $96 [: { z } z -> a c@ z -> get-hl z -> rb 0 z -> subb z -> a c! ;] opcode-add \ sub a,(hl)
               $D6 [: { z } z -> a c@ z -> nextb 0 z -> subb z -> a c! ;] opcode-add \ sub a,*

               $9f [: { z } z -> a c@ z -> a c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,a
               $98 [: { z } z -> a c@ z -> b c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,b
               $99 [: { z } z -> a c@ z -> c c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,c
               $9a [: { z } z -> a c@ z -> d c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,d
               $9b [: { z } z -> a c@ z -> e c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,e
               $9c [: { z } z -> a c@ z -> h c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,h
               $9d [: { z } z -> a c@ z -> l c@ cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,l
               $9e [: { z } z -> a c@ z -> get-hl z -> rb cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,(hl)
               $De [: { z } z -> a c@ z -> nextb cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a,*
               
               $09 [: { z } z -> get-bc z -> addhl ;] opcode-add \ add hl,bc
               $19 [: { z } z -> get-de z -> addhl ;] opcode-add \ add hl,de
               $29 [: { z } z -> get-hl z -> addhl ;] opcode-add \ add hl,hl
               $39 [: { z } z -> sp h@  z -> addhl ;] opcode-add \ add hl,sp

               $f3 [: { z } z -> state c@ iff1 iff2 or 255 xor and z -> state c! ;] opcode-add \ di
               $fb [: { z } 1 z -> iff_delay c! ;] opcode-add \ ei
               $00 [: { z } ;] opcode-add \ nop
               $76 [: { z } z -> state c@ halted or z -> state c! ;] opcode-add \ halt
               
               $3C [: { z } z -> a c@ z -> inc z -> a c! ;] opcode-add \ inc a
               $04 [: { z } z -> b c@ z -> inc z -> b c! ;] opcode-add \ inc b
               $0c [: { z } z -> c c@ z -> inc z -> c c! ;] opcode-add \ inc c
               $14 [: { z } z -> d c@ z -> inc z -> d c! ;] opcode-add \ inc d
               $1c [: { z } z -> e c@ z -> inc z -> e c! ;] opcode-add \ inc e
               $24 [: { z } z -> h c@ z -> inc z -> h c! ;] opcode-add \ inc h
               $2c [: { z } z -> l c@ z -> inc z -> l c! ;] opcode-add \ inc l
               $34 [: { z } z -> get-hl z -> rb z -> inc z -> get-hl swap z -> wb ;] opcode-add \ inc (hl)
               
               $3d [: { z } z -> a c@ z -> dec z -> a c! ;] opcode-add \ dec a
               $05 [: { z } z -> b c@ z -> dec z -> b c! ;] opcode-add \ dec b
               $0d [: { z } z -> c c@ z -> dec z -> c c! ;] opcode-add \ dec c
               $15 [: { z } z -> d c@ z -> dec z -> d c! ;] opcode-add \ dec d
               $1d [: { z } z -> e c@ z -> dec z -> e c! ;] opcode-add \ dec e
               $25 [: { z } z -> h c@ z -> dec z -> h c! ;] opcode-add \ dec h
               $2d [: { z } z -> l c@ z -> dec z -> l c! ;] opcode-add \ dec l
               $35 [: { z } z -> get-hl z -> rb z -> dec z -> get-hl swap z -> wb ;] opcode-add \ dec (hl)

               $03 [: { z } z -> get-bc 1+ z -> set-bc ;] opcode-add \ inc bc
               $13 [: { z } z -> get-de 1+ z -> set-de ;] opcode-add \ inc de
               $23 [: { z } z -> get-hl 1+ z -> set-hl ;] opcode-add \ inc hl
               $33 [: { z } z -> sp h@ 1+ z -> sp h! ;] opcode-add \ inc sp

               $0B [: { z } z -> get-bc 1- z -> set-bc ;] opcode-add \ dec bc
               $1B [: { z } z -> get-de 1- z -> set-de ;] opcode-add \ dec de
               $2B [: { z } z -> get-hl 1- z -> set-hl ;] opcode-add \ dec hl
               $3B [: { z } z -> sp h@ 1- z -> sp h! ;] opcode-add \ dec sp

               $27 [: { z } z -> daa ;] opcode-add \ daa

               $2f [: { z }
                    z -> a c@ 255 xor  dup z -> a c! 
                    z -> f c@ nf hf or or xf yf or 255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ cpl

               $37 [: { z }
                    z -> a c@
                    z -> f c@ cf or nf hf xf yf or or or  255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ scf

               $3f [: { z }
                    z -> a c@
                    z -> f c@ cf nf hf xf yf or or or or  255 xor and
                    cf z -> get-flag if hf or else cf or then
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ ccf
               
               $07 [: { z }
                    z -> a c@ $80 and cf z -> set-flag
                    z -> a c@ 1 lshift cf z -> get-flag if 1 or then dup z -> a c!
                    z -> f c@ nf hf xf yf or or or  255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ rlca

               $0F [: { z }
                    z -> a c@ $1 and cf z -> set-flag
                    z -> a c@ 1 rshift cf z -> get-flag if $80 or then dup z -> a c!
                    z -> f c@ nf hf xf yf or or or  255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ rrca

               $17 [: { z }
                    cf z -> get-flag
                    z -> a c@ $80 and cf z -> set-flag
                    z -> a c@ 1 lshift swap if 1 or then dup z -> a c!
                    z -> f c@ nf hf xf yf or or or  255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ rla
               $1F [: { z }
                    cf z -> get-flag
                    z -> a c@ $1 and cf z -> set-flag
                    z -> a c@ 1 rshift swap if $80 or then dup z -> a c!
                    z -> f c@ nf hf xf yf or or or  255 xor and
                    over 3 swap GET_BIT if xf or then
                    over 5 swap GET_BIT if yf or then
                    z -> f c!
                    drop
               ;] opcode-add \ rra
               $A7 [: { z } z -> a c@ z -> land ;] opcode-add \ and a
               $A0 [: { z } z -> b c@ z -> land ;] opcode-add \ and b
               $A1 [: { z } z -> c c@ z -> land ;] opcode-add \ and c
               $A2 [: { z } z -> d c@ z -> land ;] opcode-add \ and d
               $A3 [: { z } z -> e c@ z -> land ;] opcode-add \ and e
               $A4 [: { z } z -> h c@ z -> land ;] opcode-add \ and h
               $A5 [: { z } z -> l c@ z -> land ;] opcode-add \ and l
               $A6 [: { z } z -> get-hl z -> rb z -> land ;] opcode-add \ and (hl)
               $E6 [: { z } z -> nextb z -> land ;] opcode-add \ and *

               $AF [: { z } z -> a c@ z -> lxor ;] opcode-add \ xor a
               $A8 [: { z } z -> b c@ z -> lxor ;] opcode-add \ xor b
               $A9 [: { z } z -> c c@ z -> lxor ;] opcode-add \ xor c
               $AA [: { z } z -> d c@ z -> lxor ;] opcode-add \ xor d
               $AB [: { z } z -> e c@ z -> lxor ;] opcode-add \ xor e
               $AC [: { z } z -> h c@ z -> lxor ;] opcode-add \ xor h
               $AD [: { z } z -> l c@ z -> lxor ;] opcode-add \ xor l
               $AE [: { z } z -> get-hl z -> rb z -> lxor ;] opcode-add \ xor (hl)
               $EE [: { z } z -> nextb z -> lxor ;] opcode-add \ xor *

               $B7 [: { z } z -> a c@ z -> lor ;] opcode-add \ or a
               $B0 [: { z } z -> b c@ z -> lor ;] opcode-add \ or b
               $B1 [: { z } z -> c c@ z -> lor ;] opcode-add \ or c
               $B2 [: { z } z -> d c@ z -> lor ;] opcode-add \ or d
               $B3 [: { z } z -> e c@ z -> lor ;] opcode-add \ or e
               $B4 [: { z } z -> h c@ z -> lor ;] opcode-add \ or h
               $B5 [: { z } z -> l c@ z -> lor ;] opcode-add \ or l
               $B6 [: { z } z -> get-hl z -> rb z -> lor ;] opcode-add \ or (hl)
               $F6 [: { z } z -> nextb z -> lor ;] opcode-add \ or *

               $BF [: { z } z -> a c@ z -> cp ;] opcode-add \ cp a
               $B8 [: { z } z -> b c@ z -> cp ;] opcode-add \ cp b
               $B9 [: { z } z -> c c@ z -> cp ;] opcode-add \ cp c
               $BA [: { z } z -> d c@ z -> cp ;] opcode-add \ cp d
               $BB [: { z } z -> e c@ z -> cp ;] opcode-add \ cp e
               $BC [: { z } z -> h c@ z -> cp ;] opcode-add \ cp h
               $BD [: { z } z -> l c@ z -> cp ;] opcode-add \ cp l
               $BE [: { z } z -> get-hl z -> rb z -> cp ;] opcode-add \ cp (hl)
               $FE [: { z } z -> nextb z -> cp ;] opcode-add \ cp *

               $C3 [: { z } z -> nextw z -> jump  ;] opcode-add \ jmp (jm?)
               $C2 [: { z } zf z -> get-flag 0= z -> cond-jump ;] opcode-add \ jp nz, **
               $CA [: { z } zf z -> get-flag  z -> cond-jump ;] opcode-add \ jp z, **
               $D2 [: { z } cf z -> get-flag 0= z -> cond-jump ;] opcode-add \ jp nc, **
               $DA [: { z } cf z -> get-flag  z -> cond-jump ;] opcode-add \ jp c, **
               $E2 [: { z } pf z -> get-flag 0= z -> cond-jump ;] opcode-add \ jp po, **
               $EA [: { z } pf z -> get-flag  z -> cond-jump ;] opcode-add \ jp pe, **
               $F2 [: { z } sf z -> get-flag 0= z -> cond-jump ;] opcode-add \ jp p, **
               $FA [: { z } sf z -> get-flag  z -> cond-jump ;] opcode-add \ jp m, **

               $10 [: { z } z -> b c@ 1- 255 and dup z -> b c! 0> z -> cond-jr ;] opcode-add \ djnz
\               $18 [: { z } 
\                            z -> nextb
\                            dup $7f and swap $80 and if -128 + then
\                            z -> pc h+!
\                    ;] opcode-add \ jr *
               $18 [: { z } z -> nextb z -> jr ;] opcode-add \ JR
               $20 [: { z } zf z -> get-flag 0= z -> cond-jr ;] opcode-add \ jr nz,*
               $28 [: { z } zf z -> get-flag  z -> cond-jr ;] opcode-add \ jr z,*
               $30 [: { z } cf z -> get-flag 0= z -> cond-jr ;] opcode-add \ jr nc,*
               $38 [: { z } cf z -> get-flag  z -> cond-jr ;] opcode-add \ jr c,*

               $E9 [: { z } z -> get-hl z -> pc h! ;] opcode-add \ jp (hl)
               $CD [: { z } z -> nextw z -> call ;] opcode-add \ call

               $C4 [: { z } zf z -> get-flag 0= z -> cond-call ;] opcode-add \ cnz
               $CC [: { z } zf z -> get-flag  z -> cond-call ;] opcode-add \ cz
               $D4 [: { z } cf z -> get-flag 0= z -> cond-call ;] opcode-add \ cnc
               $DC [: { z } cf z -> get-flag  z -> cond-call ;] opcode-add \ cc
               $E4 [: { z } pf z -> get-flag 0= z -> cond-call ;] opcode-add \ cpo
               $EC [: { z } pf z -> get-flag  z -> cond-call ;] opcode-add \ cpe
               $F4 [: { z } sf z -> get-flag 0= z -> cond-call ;] opcode-add \ cp
               $FC [: { z } sf z -> get-flag  z -> cond-call ;] opcode-add \ cm

               $C9 [: { z } z -> ret ;] opcode-add \ ret
               $C0 [: { z } zf z -> get-flag 0= z -> cond-ret ;] opcode-add \ ret nz
               $C8 [: { z } zf z -> get-flag  z -> cond-ret ;] opcode-add \ ret z
               $D0 [: { z } cf z -> get-flag 0= z -> cond-ret ;] opcode-add \ ret nc
               $D8 [: { z } cf z -> get-flag  z -> cond-ret ;] opcode-add \ ret c
               $E0 [: { z } pf z -> get-flag 0= z -> cond-ret ;] opcode-add \ ret po
               $E8 [: { z } pf z -> get-flag  z -> cond-ret ;] opcode-add \ ret pe
               $F0 [: { z } sf z -> get-flag 0= z -> cond-ret ;] opcode-add \ ret p
               $F8 [: { z } sf z -> get-flag  z -> cond-ret ;] opcode-add \ ret m


               $C7 [: { z } $00 z -> call ;] opcode-add \ rst 0
               $CF [: { z } $08 z -> call ;] opcode-add \ rst 1
               $D7 [: { z } $10 z -> call ;] opcode-add \ rst 2
               $DF [: { z } $18 z -> call ;] opcode-add \ rst 3
               $E7 [: { z } $20 z -> call ;] opcode-add \ rst 4
               $EF [: { z } $28 z -> call ;] opcode-add \ rst 5
               $F7 [: { z } $30 z -> call ;] opcode-add \ rst 6
               $FF [: { z } $38 z -> call ;] opcode-add \ rst 7

               $C5 [: { z } z -> get-bc z -> pushw ;] opcode-add \ push bc
               $D5 [: { z } z -> get-de z -> pushw ;] opcode-add \ push de
               $E5 [: { z } z -> get-hl z -> pushw ;] opcode-add \ push hl
               $F5 [: { z } z -> a c@ 8 lshift z -> f c@ or z -> pushw ;] opcode-add \ push af


               $C1 [: { z } z -> popw z -> set-bc ;] opcode-add \ pop bc
               $D1 [: { z } z -> popw z -> set-de ;] opcode-add \ pop de
               $E1 [: { z } z -> popw z -> set-hl ;] opcode-add \ pop hl
               $F1 [: { z } z -> popw dup 8 rshift z -> a c! $ff and z -> f c!  ;] opcode-add \ pop af
               $DB [: { z } z -> a c@ z -> nextb
                            z -> port-in z -> a c!
                            8 lshift z -> a c@ 1+ or z -> mem_ptr h!
                            ;] opcode-add \ in a,(n)
               $D3 [: { z } 
                            z -> nextb
                            dup z -> a c@ z -> port-out
                            1+ z -> a c@ 8 lshift or z -> mem_ptr h!
               ;] opcode-add \ out (n),a
               
               $08 [: { z } 
                            z -> a c@   z -> a_ c@    z -> a c!   z -> a_ c!
                            z -> f c@   z -> f_ c@    z -> f c!   z -> f_ c!
                            ;] opcode-add \ ex af,af'
                 
               $D9 [: { z } 
                            z -> b c@   z -> b_ c@    z -> b c!   z -> b_ c!
                            z -> c c@   z -> c_ c@    z -> c c!   z -> c_ c!
                            z -> d c@   z -> d_ c@    z -> d c!   z -> d_ c!
                            z -> e c@   z -> e_ c@    z -> e c!   z -> e_ c!
                            z -> h c@   z -> h_ c@    z -> h c!   z -> h_ c!
                            z -> l c@   z -> l_ c@    z -> l c!   z -> l_ c!
                            ;] opcode-add \ exx
                
               $CB [: { z } z -> nextb z -> exec-opcode-cb ;] opcode-add \ 
               $ED [: { z } z -> nextb z -> exec-opcode-ed ;] opcode-add \ 
               $DD [: { z } z -> nextb z -> ix z -> iz ! z -> exec-opcode-ddfd ;] opcode-add \ 
               $FD [: { z } z -> nextb z -> iy z -> iz ! z -> exec-opcode-ddfd ;] opcode-add \ 
        ;

        gen-opcodes-table

        : write-opcodes-table s" create opcodes-tbl " evaluate
            256 0 do 
                opcodes-table-buffer i cells + @ ,
            loop
        ;

        write-opcodes-table
        :noname opcodes-tbl ; is opcodes-table-adr

       \ ------------------------------------------------------ 


        : gen-opcodes-ddfd-table
                $E1 [: { z } z -> popw z -> iz @ h! ;] opcode-add \ pop iz
                $E5 [: { z } z -> iz @ h@ z -> pushw ;] opcode-add \ push iz

                $E9 [: { z } z -> iz @ h@ z -> jump ;] opcode-add \ jp iz

                $09 [: { z } z -> iz @ z -> get-bc z -> addiz ;] opcode-add \ add iz,bc
                $19 [: { z } z -> iz @ z -> get-de z -> addiz ;] opcode-add \ add iz,de
                $29 [: { z } z -> iz @ z -> iz @ h@ z -> addiz ;] opcode-add \ add iz,iz
                $39 [: { z } z -> iz @ z -> sp h@ z -> addiz ;] opcode-add \ add iz,sp

                
                $84 [: { z } z -> a c@ z -> iz @ h@ 8 rshift 0 z -> addb z -> a c! ;] opcode-add \ add a, izh
                $85 [: { z } z -> a c@ z -> iz @ h@ $ff and  0 z -> addb z -> a c! ;] opcode-add \ add a, izl
                $8C [: { z } z -> a c@ z -> iz @ h@ 8 rshift cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a, izh
                $8D [: { z } z -> a c@ z -> iz @ h@ $ff and cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a, izh
                
                $86 [: { z } z -> a c@ z -> iz @ h@ z -> nextb z -> displace z -> rb 0 z -> addb z -> a c! ;] opcode-add \ add a, (iz+*)
                $8E [: { z } z -> a c@ z -> iz @ h@ z -> nextb z -> displace z -> rb cf z -> get-flag z -> addb z -> a c! ;] opcode-add \ adc a, (iz+*)
                $96 [: { z } z -> a c@ z -> iz @ h@ z -> nextb z -> displace z -> rb 0 z -> subb z -> a c! ;] opcode-add \ sub a, (iz+*)
                $9E [: { z } z -> a c@ z -> iz @ h@ z -> nextb z -> displace z -> rb cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc a, (iz+*)

                $94 [: { z } z -> a c@ z -> iz @ h@ 8 rshift 0 z -> subb z -> a c! ;] opcode-add \ sub izh
                $95 [: { z } z -> a c@ z -> iz @ h@ $ff and 0 z -> subb z -> a c! ;] opcode-add \ sub izl
                $9C [: { z } z -> a c@ z -> iz @ h@ 8 rshift cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc izh
                $9D [: { z } z -> a c@ z -> iz @ h@ $ff and cf z -> get-flag z -> subb z -> a c! ;] opcode-add \ sbc izl

                $A6 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> land  ;] opcode-add \ and (iz+*)
                $A4 [: { z } z -> iz @ h@ 8 rshift z -> land ;] opcode-add \ and izh
                $A5 [: { z } z -> iz @ h@ $ff and z -> land ;] opcode-add \ and izl

                $AE [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> lxor  ;] opcode-add \ xor (iz+*)
                $AC [: { z } z -> iz @ h@ 8 rshift z -> lxor ;] opcode-add \ xor izh
                $AD [: { z } z -> iz @ h@ $ff and z -> lxor ;] opcode-add \ xor izl

                $B6 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> lor  ;] opcode-add \ or (iz+*)
                $B4 [: { z } z -> iz @ h@ 8 rshift z -> lor ;] opcode-add \ or izh
                $B5 [: { z } z -> iz @ h@ $ff and z -> lor ;] opcode-add \ or izl

                $BE [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> cp  ;] opcode-add \ cp (iz+*)
                $BC [: { z } z -> iz @ h@ 8 rshift z -> cp ;] opcode-add \ cp izh
                $BD [: { z } z -> iz @ h@ $ff and z -> cp ;] opcode-add \ cp izl

                $23 [: { z } 1 z -> iz @ h+! ;] opcode-add \ inc iz
                $2B [: { z } -1 z -> iz @ h+! ;] opcode-add \ dec iz
                
                $34 [: { z } 
                                z -> iz @ h@ z -> nextb z -> displace 
                                dup z -> rb z -> inc
                                z -> wb
                ;] opcode-add \ inc ( iz+*)
                $35 [: { z } 
                                z -> iz @ h@ z -> nextb z -> displace 
                                dup z -> rb z -> dec
                                z -> wb
                ;] opcode-add \ dec ( iz+*)

                $24 [: { z } z -> iz @ h@ 8 rshift z -> inc 8 lshift 
                             z -> iz @ h@ $ff and or 
                             z -> iz @ h! ;] opcode-add \ inc izh
                $25 [: { z } z -> iz @ h@ 8 rshift z -> dec 8 lshift 
                             z -> iz @ h@ $ff and or 
                             z -> iz @ h! ;] opcode-add \ dec izh
                $2C [: { z } z -> iz @ h@ $ff and  z -> inc 
                             z -> iz @ h@ $ff00 and or 
                             z -> iz @ h! ;] opcode-add \ inc izl
                $2D [: { z } z -> iz @ h@ $ff and  z -> dec 
                             z -> iz @ h@ $ff00 and or 
                             z -> iz @ h! ;] opcode-add \ dec izl
                $2A [: { z } z -> nextw z -> rw z -> iz @ h! ;] opcode-add \ ld iz,(**)
                $22 [: { z } z -> nextw z -> iz @ h@ z -> ww ;] opcode-add \ ld (**),iz
                $21 [: { z } z -> nextw z -> iz @ h! ;] opcode-add \ ld iz,**
                
                $36 [: { z } 
                                z -> iz @ h@ z -> nextb z -> displace 
                                z -> nextb 
                                z -> wb
                ;] opcode-add \ ld ( iz+*),*

                $70 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> b c@ z -> wb ;] opcode-add \ ld (iz+*),b
                $71 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> c c@ z -> wb ;] opcode-add \ ld (iz+*),c
                $72 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> d c@ z -> wb ;] opcode-add \ ld (iz+*),d
                $73 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> e c@ z -> wb ;] opcode-add \ ld (iz+*),e
                $74 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> h c@ z -> wb ;] opcode-add \ ld (iz+*),h
                $75 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> l c@ z -> wb ;] opcode-add \ ld (iz+*),l
                $77 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> a c@ z -> wb ;] opcode-add \ ld (iz+*),a
                
                $46 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> b c! ;] opcode-add \ ld b,(iz+*)
                $4E [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> c c! ;] opcode-add \ ld c,(iz+*)
                $56 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> d c! ;] opcode-add \ ld d,(iz+*)
                $5E [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> e c! ;] opcode-add \ ld e,(iz+*)
                $66 [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> h c! ;] opcode-add \ ld h,(iz+*)
                $6E [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> l c! ;] opcode-add \ ld l,(iz+*)
                $7E [: { z } z -> iz @ h@ z -> nextb z -> displace z -> rb z -> a c! ;] opcode-add \ ld a,(iz+*)

                $44 [: { z } z -> iz @ h@ 8 rshift z -> b c! ;] opcode-add \ ld b,izh
                $4C [: { z } z -> iz @ h@ 8 rshift z -> c c! ;] opcode-add \ ld c,izh
                $54 [: { z } z -> iz @ h@ 8 rshift z -> d c! ;] opcode-add \ ld d,izh
                $5C [: { z } z -> iz @ h@ 8 rshift z -> e c! ;] opcode-add \ ld e,izh
                $7C [: { z } z -> iz @ h@ 8 rshift z -> a c! ;] opcode-add \ ld f,izh
                
                $45 [: { z } z -> iz @ h@ $ff and  z -> b c! ;] opcode-add \ ld b,izl
                $4D [: { z } z -> iz @ h@ $ff and  z -> c c! ;] opcode-add \ ld c,izl
                $55 [: { z } z -> iz @ h@ $ff and  z -> d c! ;] opcode-add \ ld d,izl
                $5D [: { z } z -> iz @ h@ $ff and  z -> e c! ;] opcode-add \ ld e,izl
                $7D [: { z } z -> iz @ h@ $ff and  z -> a c! ;] opcode-add \ ld f,izl

                $60 [: { z } z -> b c@ z -> iz @ 1+ c! ;] opcode-add \ ld izh,b
                $61 [: { z } z -> c c@ z -> iz @ 1+ c! ;] opcode-add \ ld izh,c
                $62 [: { z } z -> d c@ z -> iz @ 1+ c! ;] opcode-add \ ld izh,d
                $63 [: { z } z -> e c@ z -> iz @ 1+ c! ;] opcode-add \ ld izh,e
                $64 [: { z } ;] opcode-add \ ld izh,izh
                $65 [: { z } z -> iz @ c@ 
                             z -> iz @ 1+ c! ;] opcode-add \ ld izh,izl
                $67 [: { z } z -> a c@ z -> iz @ 1+ c! ;] opcode-add \ ld izh,a
                $26 [: { z } z -> nextb z -> iz @ 1+ c! ;] opcode-add \ ld izh,*

                $68 [: { z } z -> b c@ z -> iz @ c! ;] opcode-add \ ld izl,b
                $69 [: { z } z -> c c@ z -> iz @ c! ;] opcode-add \ ld izl,c
                $6A [: { z } z -> d c@ z -> iz @ c! ;] opcode-add \ ld izl,d
                $6B [: { z } z -> e c@ z -> iz @ c! ;] opcode-add \ ld izl,e
                $6C [: { z } z -> iz @ 1+ c@ 
                             z -> iz @ c! ;] opcode-add \ ld izl,izh
                $6D [: { z } ;] opcode-add \ ld izl,izl
                $6F [: { z } z -> a c@ z -> iz @ c! ;] opcode-add \ ld izl,a
                $2E [: { z } z -> nextb z -> iz @  c! ;] opcode-add \ ld izl,*

                $F9 [: { z } z -> iz @ h@ z -> sp h! ;] opcode-add \ ld sp,iz
                
                $E3 [: { z } z -> sp h@ z -> rw dup
                        z -> iz @ h@  z -> sp h@ swap z -> ww 
                        z -> iz @ h!
                        z -> mem_ptr h!
                        ;] opcode-add \ ex (sp),iz
                
                $CB [: { z } z -> iz @ h@ z -> nextb z -> displace z -> nextb swap z -> exec-opcode-dcb ;] opcode-add \
        ;

        gen-opcodes-ddfd-table

        
        : write-opcodes-ddfd-table s" create opcodes-ddfd-tbl " evaluate
            256 0 do 
                opcodes-table-buffer i cells + @ ,
            loop
        ;
        write-opcodes-ddfd-table
        :noname opcodes-ddfd-tbl ; is opcodes-ddfd-table-adr
       \ -----------------------------------------------------
        :noname { z } ." Unknown ED instruction" CR ;
        256 0 do dup opcodes-table-buffer i cells + ! loop drop

        : gen-opcodes-ed-table

                $47 [: { z } z -> a c@ z -> i_ c! ;] opcode-add \ ld i,a
                $4F [: { z } z -> a c@ z -> r  c! ;] opcode-add \ ld r,a
                $57 [: { z } 
                                z -> i_ c@ z -> a c!
                                z -> f c@ sf zf hf nf pf or or or or 255 xor and
                                z -> a c@ $80 and if sf or then
                                z -> a c@ 0= if zf or then
                                z -> state c@ iff2 and if pf or then
                                z -> f c!
                                ;] opcode-add \ ld a,i
                $5F [: { z } 
                                z -> r c@ z -> a c!
                                z -> f c@ sf zf hf nf pf or or or or 255 xor and
                                z -> a c@ $80 and if sf or then
                                z -> a c@ 0= if zf or then
                                z -> state c@ iff2 and if pf or then
                                z -> f c!
                                ;] opcode-add \ ld a,r

                    [: { z } z -> state c@ iff1 255 xor and
                             z -> state c@ iff2 and if iff1 or then z -> state c!
                             z -> ret ;] { retn }

                $45 retn opcode-add
                $55 retn opcode-add
                $5D retn opcode-add
                $65 retn opcode-add
                $6D retn opcode-add
                $75 retn opcode-add
                $7D retn opcode-add

                $4D [: { z } z -> ret ;] opcode-add \ reti


                $A0 [: { z } z -> ldi ;] opcode-add \ ldi
                $B0 [: { z } z -> ldi 
                             z -> get-bc if
                                -2 z -> pc h+!
                                5. z -> cyc 2+!
                                z -> pc h@ 1+ z -> mem_ptr h!
                                3 z -> pc h@ 8 rshift GET_BIT xf z -> set-flag
                                5 z -> pc h@ 8 rshift GET_BIT yf z -> set-flag
                             then
                ;] opcode-add \ ldir
                $A8 [: { z } z -> ldd ;] opcode-add \ ldd
                $B8 [: { z } z -> ldd
                             z -> get-bc if
                                -2 z -> pc h+!
                                5. z -> cyc 2+!
                                z -> pc h@ 1+ z -> mem_ptr h!
                                3 z -> pc h@ 8 rshift GET_BIT xf z -> set-flag
                                5 z -> pc h@ 8 rshift GET_BIT yf z -> set-flag

                             then
                ;] opcode-add \ lddr


                $A1 [: { z } z -> cpi ;] opcode-add \ cpi
                $A9 [: { z } z -> cpd ;] opcode-add \ cpd
                $B1 [: { z } z -> cpi 
                            z -> get-bc 0 <> zf z -> get-flag 0= and if
                                -2 z -> pc h+!
                                5. z -> cyc 2+!
                                z -> pc h@ 1+ z -> mem_ptr h!
                            else
                                1 z -> mem_ptr h+!
                            then

                ;] opcode-add \ cpir
                $B9 [: { z } z -> cpd
                            z -> get-bc 0 <> zf z -> get-flag 0= and if
                                -2 z -> pc h+!
                                5. z -> cyc 2+!
                                z -> pc h@ 1+ z -> mem_ptr h!
                            else
                                1 z -> mem_ptr h+!
                            then
                ;] opcode-add \ cpdr

                $40 [: { z } z -> b z -> in_r_c ;] opcode-add \ in b,(c)
                $48 [: { z } z -> c z -> in_r_c ;] opcode-add \ in c,(c)
                $50 [: { z } z -> d z -> in_r_c ;] opcode-add \ in d,(c)
                $58 [: { z } z -> e z -> in_r_c ;] opcode-add \ in e,(c)
                $60 [: { z } z -> h z -> in_r_c ;] opcode-add \ in h,(c)
                $68 [: { z } z -> l z -> in_r_c ;] opcode-add \ in l,(c)
                $70 [: { z } z -> dummy 1+ z -> in_r_c ;] opcode-add \ in (c)
                $78 [: { z } z -> a z -> in_r_c  z -> get-bc 1+ z -> mem_ptr h! ;] opcode-add \ in a,(c)
                
                $A2 [: { z } z -> ini ;] opcode-add \ ini
                $B2 [: { z } z -> ini
                                        z -> b c@ 0> if
                                            -2 z -> pc h+!
                                            5. z -> cyc 2+!
                                        then
                    ;] opcode-add \ inir
                $AA [: { z } z -> ind ;] opcode-add \ ind
                $BA [: { z } z -> ind
                                        z -> b c@ 0> if
                                            -2 z -> pc h+!
                                            5. z -> cyc 2+!
                                        then
                    ;] opcode-add \ indr

                $41 [: { z } z -> c c@ z -> b c@ z -> port-out ;] opcode-add \ out (c),b
                $49 [: { z } z -> c c@ z -> c c@ z -> port-out ;] opcode-add \ out (c),c
                $51 [: { z } z -> c c@ z -> d c@ z -> port-out ;] opcode-add \ out (c),d
                $59 [: { z } z -> c c@ z -> e c@ z -> port-out ;] opcode-add \ out (c),e
                $61 [: { z } z -> c c@ z -> h c@ z -> port-out ;] opcode-add \ out (c),h
                $69 [: { z } z -> c c@ z -> l c@ z -> port-out ;] opcode-add \ out (c),l
                $71 [: { z } z -> c c@ 0 z -> port-out ;] opcode-add \ out (c),0
                $79 [: { z } z -> c c@ z -> a c@ z -> port-out z -> get-bc 1+ z -> mem_ptr h! ;] opcode-add \ out (c),a
    
                $A3 [: { z } z -> outi ;] opcode-add \ outi
                $B3 [: { z } z -> outi 
                                        z -> b c@ 0> if 
                                            -2 z -> pc h+!
                                            5. z -> cyc 2+!
                                        then
                ;] opcode-add \ outir
                $AB [: { z } z -> outd ;] opcode-add \ outd
                $BB [: { z } z -> outd 
                                        z -> b c@ 0> if 
                                            -2 z -> pc h+!
                                            5. z -> cyc 2+!
                                        then
                ;] opcode-add \ outdr

                $42 [: { z } z -> get-bc z -> sbchl ;] opcode-add \ sbc hl,bc
                $52 [: { z } z -> get-de z -> sbchl ;] opcode-add \ sbc hl,de
                $62 [: { z } z -> get-hl z -> sbchl ;] opcode-add \ sbc hl,hl
                $72 [: { z } z -> sp h@  z -> sbchl ;] opcode-add \ sbc hl,sp

                $4A [: { z } z -> get-bc z -> adchl ;] opcode-add \ adc hl,bc
                $5A [: { z } z -> get-de z -> adchl ;] opcode-add \ adc hl,de
                $6A [: { z } z -> get-hl z -> adchl ;] opcode-add \ adc hl,hl
                $7A [: { z } z -> sp h@  z -> adchl ;] opcode-add \ adc hl,sp

                $43 [: { z } z -> nextw dup z -> get-bc z -> ww 1+ z -> mem_ptr h! ;] opcode-add \ ld (**),bc
                $53 [: { z } z -> nextw dup z -> get-de z -> ww 1+ z -> mem_ptr h! ;] opcode-add \ ld (**),de
                $63 [: { z } z -> nextw dup z -> get-hl z -> ww 1+ z -> mem_ptr h! ;] opcode-add \ ld (**),hl
                $73 [: { z } z -> nextw dup z -> sp h@  z -> ww 1+ z -> mem_ptr h! ;] opcode-add \ ld (**),sp

                $4B [: { z } z -> nextw dup z -> rw z -> set-bc 1+ z -> mem_ptr h! ;] opcode-add \ ld bc, (**)
                $5B [: { z } z -> nextw dup z -> rw z -> set-de 1+ z -> mem_ptr h! ;] opcode-add \ ld de, (**)
                $6B [: { z } z -> nextw dup z -> rw z -> set-hl 1+ z -> mem_ptr h! ;] opcode-add \ ld hl, (**)
                $7B [: { z } z -> nextw dup z -> rw z -> sp h!  1+ z -> mem_ptr h! ;] opcode-add \ ld sp, (**)
                    [: { z } 0 z -> a c@ 0 z -> subb z -> a c! ;] { neg }
                $44  neg opcode-add \ neg
                $54  neg opcode-add \ neg
                $64  neg opcode-add \ neg
                $74  neg opcode-add \ neg
                $4C  neg opcode-add \ neg
                $5C  neg opcode-add \ neg
                $6C  neg opcode-add \ neg
                $7C  neg opcode-add \ neg
                $77 [: { z } ;] opcode-add \ nop
                $7F [: { z } ;] opcode-add \ nop
                 
                $46 [: { z } 0 z -> interrupt_mode c! ;] opcode-add \ im 0
                $66 [: { z } 0 z -> interrupt_mode c! ;] opcode-add \ im 0
                $4E [: { z } 0 z -> interrupt_mode c! ;] opcode-add \ im 0
                $6E [: { z } 0 z -> interrupt_mode c! ;] opcode-add \ im 0
                $56 [: { z } 1 z -> interrupt_mode c! ;] opcode-add \ im 1
                $76 [: { z } 1 z -> interrupt_mode c! ;] opcode-add \ im 1
                $5E [: { z } 2 z -> interrupt_mode c! ;] opcode-add \ im 2
                $7E [: { z } 2 z -> interrupt_mode c! ;] opcode-add \ im 2

                $67 [: { z } 
                                z -> a c@ { _a_ }
                                z -> get-hl z -> rb { val }
                                _a_ $F0 and val $0F and or z -> a c!
                                z -> get-hl val 4 rshift _a_ 4 lshift or z -> wb
                                z -> f c@ cf and
                                3 z -> a c@ GET_BIT if xf or then
                                5 z -> a c@ GET_BIT if yf or then
                                z -> a c@ 0= if zf or then
                                z -> a c@ $80 and if sf or then
                                z -> a c@ parity if pf or then
                                z -> get-hl 1+ z -> mem_ptr h!
                                z -> f c!
                ;] opcode-add \ rrd
                $6F [: { z } 
                                z -> a c@ { _a_ }
                                z -> get-hl z -> rb { val }
                                _a_ $F0 and val 4 rshift or z -> a c!
                                z -> get-hl val 4 lshift _a_ $0F and or z -> wb
                                z -> f c@ cf and
                                3 z -> a c@ GET_BIT if xf or then
                                5 z -> a c@ GET_BIT if yf or then
                                z -> a c@ 0= if zf or then
                                z -> a c@ $80 and if sf or then
                                z -> a c@ parity if pf or then
                                z -> get-hl 1+ z -> mem_ptr h!
                                z -> f c!
                ;] opcode-add \ rld

        ;

        gen-opcodes-ed-table

        
        : write-opcodes-ed-table s" create opcodes-ed-tbl " evaluate
            256 0 do 
                opcodes-table-buffer i cells + @ ,
            loop
        ;
        write-opcodes-ed-table
        :noname opcodes-ed-tbl ; is opcodes-ed-table-adr



    end-module> import
end-module
