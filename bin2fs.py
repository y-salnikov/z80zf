#!/usr/bin/python3
import sys, os



def main():
    if len(sys.argv) < 2:
        print("Filename required")
        exit(1)
    fn=sys.argv[1]
    l=os.path.getsize(fn)
    with open(fn,'rb') as infile, open(fn+".fs",'w') as outfile:
        outfile.write("%d constant %s-len\n" %(l,fn.split('.')[0]))
        outfile.write("create %s \n" % (fn.split('.')[0]))
        n=0
        while(True):
            b=infile.read(1)
            if not b: break
            outfile.write("$%02X c, " % (b[0]))
            n+=1
            if n==10:
                outfile.write("\n")
                n=0
        outfile.write("\n")
if __name__=="__main__": main()


