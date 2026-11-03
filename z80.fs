\ Based on https://github.com/superzazu/z80

begin-module z80
    begin-module z80-internal
    oo import
    
    : -> [inlined] ;
    
    0 bit constant sf 
    1 bit constant zf
    2 bit constant yf
    3 bit constant hf
    4 bit constant xf
    5 bit constant pf
    6 bit constant nf
    7 bit constant cf 

    0 bit constant iff1
    1 bit constant iff2
    2 bit constant halted
    3 bit constant int_pending
    4 bit constant nmi_pending

    <object> begin-class <z80-class>
        cell member read-byte-cb   ( buf offset -- byte )
        cell member write-byte-cb  ( buf offset byte -- )
        cell member port-in-cb     ( port -- byte )
        cell member port-out-cb    ( port byte -- )
        cell member userdata 
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
        1 member iff_delay
        1 member interrupt_mode
        1 member int_data
        1 member state

        method z80-init ( self -- )
        method z80-step ( self -- )
        method z80-debug-output ( self -- )
        method z80-gen-nmi ( self -- )
        method z80-gen-int ( data self -- )
        method set-read-cb ( ex self --    )
        method set-write-cb ( ex self --    )
        method set-in-cb ( ex self --    )
        method set-out-cb ( ex self --    )

    end-class


    <z80-class> begin-implement
    end-implement

    end-module> import
end-module
