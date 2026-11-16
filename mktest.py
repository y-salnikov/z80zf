#!/usr/bin/python3

import json

JSON_PATH="/home/jarik/src/z80/z80/v1/"
tests=[ "dd %02x" % (i) for i in range(0x40,0x50)  ]

#tests = []
#tests.remove("dd fd")
N_tests=5

null=None

with open("jtests.fs", "w") as ffile:
    ffile.write(": jtests \n")
    ffile.write(" depth { dpt } \n")
    for test in tests:
        with open(JSON_PATH+test+".json","r") as jfile:
            td=json.loads(jfile.read())
            for N in range(N_tests):
                j=td[N]
                ffile.write('." %s : " \n' %(j["name"]))
                i=j["initial"]
                ffile.write("%d cpu -> pc h! " %(i["pc"]))
                ffile.write("%d cpu -> sp h! " %(i["sp"]))
                ffile.write("\n")
                ffile.write("%d cpu -> a c! " %(i["a"]))
                ffile.write("%d cpu -> b c! " %(i["b"]))
                ffile.write("%d cpu -> c c! " %(i["c"]))
                ffile.write("%d cpu -> d c! " %(i["d"]))
                ffile.write("\n")
                ffile.write("%d cpu -> e c! " %(i["e"]))
                ffile.write("%d cpu -> f c! " %(i["f"]))
                ffile.write("%d cpu -> h c! " %(i["h"]))
                ffile.write("%d cpu -> l c! " %(i["l"]))
                ffile.write("\n")
                ffile.write("%d cpu -> i_ c! " %(i["i"]))
                ffile.write("%d cpu -> r c! " %(i["r"]))
                ffile.write("%d cpu -> mem_ptr h! " %(i["wz"]))
                ffile.write("\n")
                ffile.write("%d cpu -> ix h! " %(i["ix"]))
                ffile.write("%d cpu -> iy h! " %(i["iy"]))
                ffile.write("\n")
                ffile.write("%d cpu -> a_ c! %d cpu -> f_ c! " %(i["af_"]>>8,i["af_"] & 0xff))
                ffile.write("%d cpu -> b_ c! %d cpu -> c_ c! " %(i["bc_"]>>8,i["bc_"] & 0xff))
                ffile.write("\n")
                ffile.write("%d cpu -> d_ c! %d cpu -> e_ c! " %(i["de_"]>>8,i["de_"] & 0xff))
                ffile.write("%d cpu -> h_ c! %d cpu -> l_ c! " %(i["hl_"]>>8,i["hl_"] & 0xff))
                ffile.write("\n")
                for r in i["ram"]:
                    ffile.write("%d ram %d + c! " % (r[1],r[0]))
                ffile.write("\n")
                ffile.write("depth to dpt \n")
                ffile.write("cpu -> step \n")
                ffile.write("0 \n")
                f=j["final"]
                ffile.write("cpu -> a c@ %d <> if 0 bit or then \n" % (f["a"]))
                ffile.write("cpu -> b c@ %d <> if 1 bit or then \n" % (f["b"]))
                ffile.write("cpu -> c c@ %d <> if 2 bit or then \n" % (f["c"]))
                ffile.write("cpu -> d c@ %d <> if 3 bit or then \n" % (f["d"]))
                ffile.write("cpu -> e c@ %d <> if 4 bit or then \n" % (f["e"]))
                ffile.write("cpu -> f c@ %d <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space %d h.2 [char] ] emit space then \n" % (f["f"],f["f"]))
                ffile.write("cpu -> h c@ %d <> if 6 bit or then \n" % (f["h"]))
                ffile.write("cpu -> l c@ %d <> if 7 bit or then \n" % (f["l"]))
                ffile.write("cpu -> i_ c@ %d <> if 8 bit or then \n" % (f["i"]))
                ffile.write("cpu -> r c@ %d <> if 9 bit or then \n" % (f["r"]))
                ffile.write("cpu -> a_ c@ %d <> cpu -> f_ c@ %d <> or if 10 bit or then \n" %(f["af_"]>>8,f["af_"] & 0xff))
                ffile.write("cpu -> b_ c@ %d <> cpu -> c_ c@ %d <> or if 11 bit or then \n" %(f["bc_"]>>8,f["bc_"] & 0xff))
                ffile.write("cpu -> d_ c@ %d <> cpu -> e_ c@ %d <> or if 12 bit or then \n" %(f["de_"]>>8,f["de_"] & 0xff))
                ffile.write("cpu -> h_ c@ %d <> cpu -> l_ c@ %d <> or if 13 bit or then \n" %(f["hl_"]>>8,f["hl_"] & 0xff))
                ffile.write("cpu -> ix h@ %d <> if 14 bit or then \n" % (f["ix"]))
                ffile.write("cpu -> iy h@ %d <> if 15 bit or then \n" % (f["iy"]))
                ffile.write("cpu -> pc h@ %d <> if 16 bit or then \n" % (f["pc"]))
                ffile.write("cpu -> sp h@ %d <> if 17 bit or then \n" % (f["sp"]))
                ffile.write("cpu -> mem_ptr h@ %d <> if 18 bit or then \n" % (f["wz"]))
                for r in f["ram"]:
                    ffile.write("%d ram + c@ %d <> if 19 bit or then \n" % (r[0],r[1]))
                ffile.write("depth dpt 1+ <> if 20 bit or then \n")
                ffile.write('dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr \n')

    ffile.write(" depth . cr ; \n")


