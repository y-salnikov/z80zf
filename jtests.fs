: jtests 
 depth { dpt } 
." DD 40 0000 : " 
56593 cpu -> pc h! 37086 cpu -> sp h! 
43 cpu -> a c! 172 cpu -> b c! 200 cpu -> c c! 50 cpu -> d c! 
62 cpu -> e c! 41 cpu -> f c! 88 cpu -> h c! 120 cpu -> l c! 
80 cpu -> i_ c! 59 cpu -> r c! 4751 cpu -> mem_ptr h! 
58508 cpu -> ix h! 49991 cpu -> iy h! 
220 cpu -> a_ c! 39 cpu -> f_ c! 59 cpu -> b_ c! 5 cpu -> c_ c! 
56 cpu -> d_ c! 50 cpu -> e_ c! 56 cpu -> h_ c! 136 cpu -> l_ c! 
221 ram 56593 + c! 64 ram 56594 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 43 <> if 0 bit or then 
cpu -> b c@ 172 <> if 1 bit or then 
cpu -> c c@ 200 <> if 2 bit or then 
cpu -> d c@ 50 <> if 3 bit or then 
cpu -> e c@ 62 <> if 4 bit or then 
cpu -> f c@ 41 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 41 h.2 [char] ] emit space then 
cpu -> h c@ 88 <> if 6 bit or then 
cpu -> l c@ 120 <> if 7 bit or then 
cpu -> i_ c@ 80 <> if 8 bit or then 
cpu -> r c@ 61 <> if 9 bit or then 
cpu -> a_ c@ 220 <> cpu -> f_ c@ 39 <> or if 10 bit or then 
cpu -> b_ c@ 59 <> cpu -> c_ c@ 5 <> or if 11 bit or then 
cpu -> d_ c@ 56 <> cpu -> e_ c@ 50 <> or if 12 bit or then 
cpu -> h_ c@ 56 <> cpu -> l_ c@ 136 <> or if 13 bit or then 
cpu -> ix h@ 58508 <> if 14 bit or then 
cpu -> iy h@ 49991 <> if 15 bit or then 
cpu -> pc h@ 56595 <> if 16 bit or then 
cpu -> sp h@ 37086 <> if 17 bit or then 
cpu -> mem_ptr h@ 4751 <> if 18 bit or then 
56593 ram + c@ 221 <> if 19 bit or then 
56594 ram + c@ 64 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 40 0001 : " 
25747 cpu -> pc h! 2936 cpu -> sp h! 
148 cpu -> a c! 167 cpu -> b c! 229 cpu -> c c! 94 cpu -> d c! 
65 cpu -> e c! 91 cpu -> f c! 91 cpu -> h c! 66 cpu -> l c! 
223 cpu -> i_ c! 76 cpu -> r c! 21556 cpu -> mem_ptr h! 
59783 cpu -> ix h! 9350 cpu -> iy h! 
186 cpu -> a_ c! 190 cpu -> f_ c! 254 cpu -> b_ c! 122 cpu -> c_ c! 
184 cpu -> d_ c! 193 cpu -> e_ c! 154 cpu -> h_ c! 218 cpu -> l_ c! 
221 ram 25747 + c! 64 ram 25748 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 148 <> if 0 bit or then 
cpu -> b c@ 167 <> if 1 bit or then 
cpu -> c c@ 229 <> if 2 bit or then 
cpu -> d c@ 94 <> if 3 bit or then 
cpu -> e c@ 65 <> if 4 bit or then 
cpu -> f c@ 91 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 91 h.2 [char] ] emit space then 
cpu -> h c@ 91 <> if 6 bit or then 
cpu -> l c@ 66 <> if 7 bit or then 
cpu -> i_ c@ 223 <> if 8 bit or then 
cpu -> r c@ 78 <> if 9 bit or then 
cpu -> a_ c@ 186 <> cpu -> f_ c@ 190 <> or if 10 bit or then 
cpu -> b_ c@ 254 <> cpu -> c_ c@ 122 <> or if 11 bit or then 
cpu -> d_ c@ 184 <> cpu -> e_ c@ 193 <> or if 12 bit or then 
cpu -> h_ c@ 154 <> cpu -> l_ c@ 218 <> or if 13 bit or then 
cpu -> ix h@ 59783 <> if 14 bit or then 
cpu -> iy h@ 9350 <> if 15 bit or then 
cpu -> pc h@ 25749 <> if 16 bit or then 
cpu -> sp h@ 2936 <> if 17 bit or then 
cpu -> mem_ptr h@ 21556 <> if 18 bit or then 
25747 ram + c@ 221 <> if 19 bit or then 
25748 ram + c@ 64 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 40 0002 : " 
13638 cpu -> pc h! 57953 cpu -> sp h! 
59 cpu -> a c! 153 cpu -> b c! 40 cpu -> c c! 14 cpu -> d c! 
15 cpu -> e c! 192 cpu -> f c! 114 cpu -> h c! 200 cpu -> l c! 
252 cpu -> i_ c! 124 cpu -> r c! 16684 cpu -> mem_ptr h! 
59060 cpu -> ix h! 22117 cpu -> iy h! 
4 cpu -> a_ c! 215 cpu -> f_ c! 187 cpu -> b_ c! 28 cpu -> c_ c! 
53 cpu -> d_ c! 160 cpu -> e_ c! 161 cpu -> h_ c! 232 cpu -> l_ c! 
221 ram 13638 + c! 64 ram 13639 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 59 <> if 0 bit or then 
cpu -> b c@ 153 <> if 1 bit or then 
cpu -> c c@ 40 <> if 2 bit or then 
cpu -> d c@ 14 <> if 3 bit or then 
cpu -> e c@ 15 <> if 4 bit or then 
cpu -> f c@ 192 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 192 h.2 [char] ] emit space then 
cpu -> h c@ 114 <> if 6 bit or then 
cpu -> l c@ 200 <> if 7 bit or then 
cpu -> i_ c@ 252 <> if 8 bit or then 
cpu -> r c@ 126 <> if 9 bit or then 
cpu -> a_ c@ 4 <> cpu -> f_ c@ 215 <> or if 10 bit or then 
cpu -> b_ c@ 187 <> cpu -> c_ c@ 28 <> or if 11 bit or then 
cpu -> d_ c@ 53 <> cpu -> e_ c@ 160 <> or if 12 bit or then 
cpu -> h_ c@ 161 <> cpu -> l_ c@ 232 <> or if 13 bit or then 
cpu -> ix h@ 59060 <> if 14 bit or then 
cpu -> iy h@ 22117 <> if 15 bit or then 
cpu -> pc h@ 13640 <> if 16 bit or then 
cpu -> sp h@ 57953 <> if 17 bit or then 
cpu -> mem_ptr h@ 16684 <> if 18 bit or then 
13638 ram + c@ 221 <> if 19 bit or then 
13639 ram + c@ 64 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 40 0003 : " 
45816 cpu -> pc h! 37117 cpu -> sp h! 
81 cpu -> a c! 2 cpu -> b c! 15 cpu -> c c! 26 cpu -> d c! 
230 cpu -> e c! 10 cpu -> f c! 53 cpu -> h c! 124 cpu -> l c! 
23 cpu -> i_ c! 99 cpu -> r c! 2170 cpu -> mem_ptr h! 
36286 cpu -> ix h! 34761 cpu -> iy h! 
99 cpu -> a_ c! 161 cpu -> f_ c! 113 cpu -> b_ c! 96 cpu -> c_ c! 
215 cpu -> d_ c! 39 cpu -> e_ c! 167 cpu -> h_ c! 38 cpu -> l_ c! 
221 ram 45816 + c! 64 ram 45817 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 81 <> if 0 bit or then 
cpu -> b c@ 2 <> if 1 bit or then 
cpu -> c c@ 15 <> if 2 bit or then 
cpu -> d c@ 26 <> if 3 bit or then 
cpu -> e c@ 230 <> if 4 bit or then 
cpu -> f c@ 10 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 10 h.2 [char] ] emit space then 
cpu -> h c@ 53 <> if 6 bit or then 
cpu -> l c@ 124 <> if 7 bit or then 
cpu -> i_ c@ 23 <> if 8 bit or then 
cpu -> r c@ 101 <> if 9 bit or then 
cpu -> a_ c@ 99 <> cpu -> f_ c@ 161 <> or if 10 bit or then 
cpu -> b_ c@ 113 <> cpu -> c_ c@ 96 <> or if 11 bit or then 
cpu -> d_ c@ 215 <> cpu -> e_ c@ 39 <> or if 12 bit or then 
cpu -> h_ c@ 167 <> cpu -> l_ c@ 38 <> or if 13 bit or then 
cpu -> ix h@ 36286 <> if 14 bit or then 
cpu -> iy h@ 34761 <> if 15 bit or then 
cpu -> pc h@ 45818 <> if 16 bit or then 
cpu -> sp h@ 37117 <> if 17 bit or then 
cpu -> mem_ptr h@ 2170 <> if 18 bit or then 
45816 ram + c@ 221 <> if 19 bit or then 
45817 ram + c@ 64 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 40 0004 : " 
9176 cpu -> pc h! 42780 cpu -> sp h! 
73 cpu -> a c! 134 cpu -> b c! 46 cpu -> c c! 121 cpu -> d c! 
233 cpu -> e c! 50 cpu -> f c! 215 cpu -> h c! 27 cpu -> l c! 
160 cpu -> i_ c! 109 cpu -> r c! 64610 cpu -> mem_ptr h! 
1187 cpu -> ix h! 37153 cpu -> iy h! 
122 cpu -> a_ c! 242 cpu -> f_ c! 73 cpu -> b_ c! 167 cpu -> c_ c! 
90 cpu -> d_ c! 245 cpu -> e_ c! 198 cpu -> h_ c! 233 cpu -> l_ c! 
221 ram 9176 + c! 64 ram 9177 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 73 <> if 0 bit or then 
cpu -> b c@ 134 <> if 1 bit or then 
cpu -> c c@ 46 <> if 2 bit or then 
cpu -> d c@ 121 <> if 3 bit or then 
cpu -> e c@ 233 <> if 4 bit or then 
cpu -> f c@ 50 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 50 h.2 [char] ] emit space then 
cpu -> h c@ 215 <> if 6 bit or then 
cpu -> l c@ 27 <> if 7 bit or then 
cpu -> i_ c@ 160 <> if 8 bit or then 
cpu -> r c@ 111 <> if 9 bit or then 
cpu -> a_ c@ 122 <> cpu -> f_ c@ 242 <> or if 10 bit or then 
cpu -> b_ c@ 73 <> cpu -> c_ c@ 167 <> or if 11 bit or then 
cpu -> d_ c@ 90 <> cpu -> e_ c@ 245 <> or if 12 bit or then 
cpu -> h_ c@ 198 <> cpu -> l_ c@ 233 <> or if 13 bit or then 
cpu -> ix h@ 1187 <> if 14 bit or then 
cpu -> iy h@ 37153 <> if 15 bit or then 
cpu -> pc h@ 9178 <> if 16 bit or then 
cpu -> sp h@ 42780 <> if 17 bit or then 
cpu -> mem_ptr h@ 64610 <> if 18 bit or then 
9176 ram + c@ 221 <> if 19 bit or then 
9177 ram + c@ 64 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 41 0000 : " 
15886 cpu -> pc h! 36163 cpu -> sp h! 
87 cpu -> a c! 91 cpu -> b c! 69 cpu -> c c! 100 cpu -> d c! 
2 cpu -> e c! 159 cpu -> f c! 188 cpu -> h c! 246 cpu -> l c! 
48 cpu -> i_ c! 110 cpu -> r c! 61887 cpu -> mem_ptr h! 
53050 cpu -> ix h! 16024 cpu -> iy h! 
78 cpu -> a_ c! 83 cpu -> f_ c! 84 cpu -> b_ c! 59 cpu -> c_ c! 
47 cpu -> d_ c! 180 cpu -> e_ c! 123 cpu -> h_ c! 0 cpu -> l_ c! 
221 ram 15886 + c! 65 ram 15887 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 87 <> if 0 bit or then 
cpu -> b c@ 69 <> if 1 bit or then 
cpu -> c c@ 69 <> if 2 bit or then 
cpu -> d c@ 100 <> if 3 bit or then 
cpu -> e c@ 2 <> if 4 bit or then 
cpu -> f c@ 159 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 159 h.2 [char] ] emit space then 
cpu -> h c@ 188 <> if 6 bit or then 
cpu -> l c@ 246 <> if 7 bit or then 
cpu -> i_ c@ 48 <> if 8 bit or then 
cpu -> r c@ 112 <> if 9 bit or then 
cpu -> a_ c@ 78 <> cpu -> f_ c@ 83 <> or if 10 bit or then 
cpu -> b_ c@ 84 <> cpu -> c_ c@ 59 <> or if 11 bit or then 
cpu -> d_ c@ 47 <> cpu -> e_ c@ 180 <> or if 12 bit or then 
cpu -> h_ c@ 123 <> cpu -> l_ c@ 0 <> or if 13 bit or then 
cpu -> ix h@ 53050 <> if 14 bit or then 
cpu -> iy h@ 16024 <> if 15 bit or then 
cpu -> pc h@ 15888 <> if 16 bit or then 
cpu -> sp h@ 36163 <> if 17 bit or then 
cpu -> mem_ptr h@ 61887 <> if 18 bit or then 
15886 ram + c@ 221 <> if 19 bit or then 
15887 ram + c@ 65 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 41 0001 : " 
64752 cpu -> pc h! 41824 cpu -> sp h! 
162 cpu -> a c! 108 cpu -> b c! 226 cpu -> c c! 150 cpu -> d c! 
62 cpu -> e c! 206 cpu -> f c! 69 cpu -> h c! 71 cpu -> l c! 
160 cpu -> i_ c! 32 cpu -> r c! 3200 cpu -> mem_ptr h! 
10259 cpu -> ix h! 59641 cpu -> iy h! 
179 cpu -> a_ c! 53 cpu -> f_ c! 179 cpu -> b_ c! 65 cpu -> c_ c! 
35 cpu -> d_ c! 77 cpu -> e_ c! 70 cpu -> h_ c! 172 cpu -> l_ c! 
221 ram 64752 + c! 65 ram 64753 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 162 <> if 0 bit or then 
cpu -> b c@ 226 <> if 1 bit or then 
cpu -> c c@ 226 <> if 2 bit or then 
cpu -> d c@ 150 <> if 3 bit or then 
cpu -> e c@ 62 <> if 4 bit or then 
cpu -> f c@ 206 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 206 h.2 [char] ] emit space then 
cpu -> h c@ 69 <> if 6 bit or then 
cpu -> l c@ 71 <> if 7 bit or then 
cpu -> i_ c@ 160 <> if 8 bit or then 
cpu -> r c@ 34 <> if 9 bit or then 
cpu -> a_ c@ 179 <> cpu -> f_ c@ 53 <> or if 10 bit or then 
cpu -> b_ c@ 179 <> cpu -> c_ c@ 65 <> or if 11 bit or then 
cpu -> d_ c@ 35 <> cpu -> e_ c@ 77 <> or if 12 bit or then 
cpu -> h_ c@ 70 <> cpu -> l_ c@ 172 <> or if 13 bit or then 
cpu -> ix h@ 10259 <> if 14 bit or then 
cpu -> iy h@ 59641 <> if 15 bit or then 
cpu -> pc h@ 64754 <> if 16 bit or then 
cpu -> sp h@ 41824 <> if 17 bit or then 
cpu -> mem_ptr h@ 3200 <> if 18 bit or then 
64752 ram + c@ 221 <> if 19 bit or then 
64753 ram + c@ 65 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 41 0002 : " 
61212 cpu -> pc h! 23909 cpu -> sp h! 
254 cpu -> a c! 15 cpu -> b c! 227 cpu -> c c! 211 cpu -> d c! 
151 cpu -> e c! 217 cpu -> f c! 160 cpu -> h c! 98 cpu -> l c! 
93 cpu -> i_ c! 44 cpu -> r c! 34822 cpu -> mem_ptr h! 
26571 cpu -> ix h! 51587 cpu -> iy h! 
229 cpu -> a_ c! 33 cpu -> f_ c! 20 cpu -> b_ c! 58 cpu -> c_ c! 
127 cpu -> d_ c! 193 cpu -> e_ c! 200 cpu -> h_ c! 91 cpu -> l_ c! 
221 ram 61212 + c! 65 ram 61213 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 254 <> if 0 bit or then 
cpu -> b c@ 227 <> if 1 bit or then 
cpu -> c c@ 227 <> if 2 bit or then 
cpu -> d c@ 211 <> if 3 bit or then 
cpu -> e c@ 151 <> if 4 bit or then 
cpu -> f c@ 217 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 217 h.2 [char] ] emit space then 
cpu -> h c@ 160 <> if 6 bit or then 
cpu -> l c@ 98 <> if 7 bit or then 
cpu -> i_ c@ 93 <> if 8 bit or then 
cpu -> r c@ 46 <> if 9 bit or then 
cpu -> a_ c@ 229 <> cpu -> f_ c@ 33 <> or if 10 bit or then 
cpu -> b_ c@ 20 <> cpu -> c_ c@ 58 <> or if 11 bit or then 
cpu -> d_ c@ 127 <> cpu -> e_ c@ 193 <> or if 12 bit or then 
cpu -> h_ c@ 200 <> cpu -> l_ c@ 91 <> or if 13 bit or then 
cpu -> ix h@ 26571 <> if 14 bit or then 
cpu -> iy h@ 51587 <> if 15 bit or then 
cpu -> pc h@ 61214 <> if 16 bit or then 
cpu -> sp h@ 23909 <> if 17 bit or then 
cpu -> mem_ptr h@ 34822 <> if 18 bit or then 
61212 ram + c@ 221 <> if 19 bit or then 
61213 ram + c@ 65 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 41 0003 : " 
51662 cpu -> pc h! 25841 cpu -> sp h! 
171 cpu -> a c! 203 cpu -> b c! 29 cpu -> c c! 183 cpu -> d c! 
188 cpu -> e c! 76 cpu -> f c! 12 cpu -> h c! 43 cpu -> l c! 
227 cpu -> i_ c! 63 cpu -> r c! 64754 cpu -> mem_ptr h! 
48089 cpu -> ix h! 42233 cpu -> iy h! 
212 cpu -> a_ c! 12 cpu -> f_ c! 133 cpu -> b_ c! 53 cpu -> c_ c! 
69 cpu -> d_ c! 165 cpu -> e_ c! 35 cpu -> h_ c! 17 cpu -> l_ c! 
221 ram 51662 + c! 65 ram 51663 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 171 <> if 0 bit or then 
cpu -> b c@ 29 <> if 1 bit or then 
cpu -> c c@ 29 <> if 2 bit or then 
cpu -> d c@ 183 <> if 3 bit or then 
cpu -> e c@ 188 <> if 4 bit or then 
cpu -> f c@ 76 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 76 h.2 [char] ] emit space then 
cpu -> h c@ 12 <> if 6 bit or then 
cpu -> l c@ 43 <> if 7 bit or then 
cpu -> i_ c@ 227 <> if 8 bit or then 
cpu -> r c@ 65 <> if 9 bit or then 
cpu -> a_ c@ 212 <> cpu -> f_ c@ 12 <> or if 10 bit or then 
cpu -> b_ c@ 133 <> cpu -> c_ c@ 53 <> or if 11 bit or then 
cpu -> d_ c@ 69 <> cpu -> e_ c@ 165 <> or if 12 bit or then 
cpu -> h_ c@ 35 <> cpu -> l_ c@ 17 <> or if 13 bit or then 
cpu -> ix h@ 48089 <> if 14 bit or then 
cpu -> iy h@ 42233 <> if 15 bit or then 
cpu -> pc h@ 51664 <> if 16 bit or then 
cpu -> sp h@ 25841 <> if 17 bit or then 
cpu -> mem_ptr h@ 64754 <> if 18 bit or then 
51662 ram + c@ 221 <> if 19 bit or then 
51663 ram + c@ 65 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 41 0004 : " 
26126 cpu -> pc h! 10161 cpu -> sp h! 
90 cpu -> a c! 22 cpu -> b c! 86 cpu -> c c! 29 cpu -> d c! 
216 cpu -> e c! 22 cpu -> f c! 213 cpu -> h c! 176 cpu -> l c! 
18 cpu -> i_ c! 24 cpu -> r c! 44033 cpu -> mem_ptr h! 
46172 cpu -> ix h! 1712 cpu -> iy h! 
152 cpu -> a_ c! 92 cpu -> f_ c! 103 cpu -> b_ c! 43 cpu -> c_ c! 
116 cpu -> d_ c! 3 cpu -> e_ c! 77 cpu -> h_ c! 48 cpu -> l_ c! 
221 ram 26126 + c! 65 ram 26127 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 90 <> if 0 bit or then 
cpu -> b c@ 86 <> if 1 bit or then 
cpu -> c c@ 86 <> if 2 bit or then 
cpu -> d c@ 29 <> if 3 bit or then 
cpu -> e c@ 216 <> if 4 bit or then 
cpu -> f c@ 22 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 22 h.2 [char] ] emit space then 
cpu -> h c@ 213 <> if 6 bit or then 
cpu -> l c@ 176 <> if 7 bit or then 
cpu -> i_ c@ 18 <> if 8 bit or then 
cpu -> r c@ 26 <> if 9 bit or then 
cpu -> a_ c@ 152 <> cpu -> f_ c@ 92 <> or if 10 bit or then 
cpu -> b_ c@ 103 <> cpu -> c_ c@ 43 <> or if 11 bit or then 
cpu -> d_ c@ 116 <> cpu -> e_ c@ 3 <> or if 12 bit or then 
cpu -> h_ c@ 77 <> cpu -> l_ c@ 48 <> or if 13 bit or then 
cpu -> ix h@ 46172 <> if 14 bit or then 
cpu -> iy h@ 1712 <> if 15 bit or then 
cpu -> pc h@ 26128 <> if 16 bit or then 
cpu -> sp h@ 10161 <> if 17 bit or then 
cpu -> mem_ptr h@ 44033 <> if 18 bit or then 
26126 ram + c@ 221 <> if 19 bit or then 
26127 ram + c@ 65 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 42 0000 : " 
3634 cpu -> pc h! 60523 cpu -> sp h! 
173 cpu -> a c! 142 cpu -> b c! 98 cpu -> c c! 64 cpu -> d c! 
150 cpu -> e c! 55 cpu -> f c! 207 cpu -> h c! 130 cpu -> l c! 
241 cpu -> i_ c! 87 cpu -> r c! 30347 cpu -> mem_ptr h! 
3089 cpu -> ix h! 48302 cpu -> iy h! 
13 cpu -> a_ c! 50 cpu -> f_ c! 152 cpu -> b_ c! 11 cpu -> c_ c! 
231 cpu -> d_ c! 90 cpu -> e_ c! 76 cpu -> h_ c! 163 cpu -> l_ c! 
221 ram 3634 + c! 66 ram 3635 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 173 <> if 0 bit or then 
cpu -> b c@ 64 <> if 1 bit or then 
cpu -> c c@ 98 <> if 2 bit or then 
cpu -> d c@ 64 <> if 3 bit or then 
cpu -> e c@ 150 <> if 4 bit or then 
cpu -> f c@ 55 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 55 h.2 [char] ] emit space then 
cpu -> h c@ 207 <> if 6 bit or then 
cpu -> l c@ 130 <> if 7 bit or then 
cpu -> i_ c@ 241 <> if 8 bit or then 
cpu -> r c@ 89 <> if 9 bit or then 
cpu -> a_ c@ 13 <> cpu -> f_ c@ 50 <> or if 10 bit or then 
cpu -> b_ c@ 152 <> cpu -> c_ c@ 11 <> or if 11 bit or then 
cpu -> d_ c@ 231 <> cpu -> e_ c@ 90 <> or if 12 bit or then 
cpu -> h_ c@ 76 <> cpu -> l_ c@ 163 <> or if 13 bit or then 
cpu -> ix h@ 3089 <> if 14 bit or then 
cpu -> iy h@ 48302 <> if 15 bit or then 
cpu -> pc h@ 3636 <> if 16 bit or then 
cpu -> sp h@ 60523 <> if 17 bit or then 
cpu -> mem_ptr h@ 30347 <> if 18 bit or then 
3634 ram + c@ 221 <> if 19 bit or then 
3635 ram + c@ 66 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 42 0001 : " 
38571 cpu -> pc h! 59731 cpu -> sp h! 
226 cpu -> a c! 92 cpu -> b c! 91 cpu -> c c! 215 cpu -> d c! 
57 cpu -> e c! 54 cpu -> f c! 22 cpu -> h c! 202 cpu -> l c! 
55 cpu -> i_ c! 54 cpu -> r c! 40860 cpu -> mem_ptr h! 
20206 cpu -> ix h! 10099 cpu -> iy h! 
197 cpu -> a_ c! 212 cpu -> f_ c! 76 cpu -> b_ c! 22 cpu -> c_ c! 
46 cpu -> d_ c! 213 cpu -> e_ c! 27 cpu -> h_ c! 200 cpu -> l_ c! 
221 ram 38571 + c! 66 ram 38572 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 226 <> if 0 bit or then 
cpu -> b c@ 215 <> if 1 bit or then 
cpu -> c c@ 91 <> if 2 bit or then 
cpu -> d c@ 215 <> if 3 bit or then 
cpu -> e c@ 57 <> if 4 bit or then 
cpu -> f c@ 54 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 54 h.2 [char] ] emit space then 
cpu -> h c@ 22 <> if 6 bit or then 
cpu -> l c@ 202 <> if 7 bit or then 
cpu -> i_ c@ 55 <> if 8 bit or then 
cpu -> r c@ 56 <> if 9 bit or then 
cpu -> a_ c@ 197 <> cpu -> f_ c@ 212 <> or if 10 bit or then 
cpu -> b_ c@ 76 <> cpu -> c_ c@ 22 <> or if 11 bit or then 
cpu -> d_ c@ 46 <> cpu -> e_ c@ 213 <> or if 12 bit or then 
cpu -> h_ c@ 27 <> cpu -> l_ c@ 200 <> or if 13 bit or then 
cpu -> ix h@ 20206 <> if 14 bit or then 
cpu -> iy h@ 10099 <> if 15 bit or then 
cpu -> pc h@ 38573 <> if 16 bit or then 
cpu -> sp h@ 59731 <> if 17 bit or then 
cpu -> mem_ptr h@ 40860 <> if 18 bit or then 
38571 ram + c@ 221 <> if 19 bit or then 
38572 ram + c@ 66 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 42 0002 : " 
53207 cpu -> pc h! 24836 cpu -> sp h! 
81 cpu -> a c! 1 cpu -> b c! 216 cpu -> c c! 99 cpu -> d c! 
39 cpu -> e c! 96 cpu -> f c! 240 cpu -> h c! 190 cpu -> l c! 
202 cpu -> i_ c! 92 cpu -> r c! 58366 cpu -> mem_ptr h! 
46089 cpu -> ix h! 23837 cpu -> iy h! 
153 cpu -> a_ c! 137 cpu -> f_ c! 73 cpu -> b_ c! 133 cpu -> c_ c! 
180 cpu -> d_ c! 210 cpu -> e_ c! 7 cpu -> h_ c! 44 cpu -> l_ c! 
221 ram 53207 + c! 66 ram 53208 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 81 <> if 0 bit or then 
cpu -> b c@ 99 <> if 1 bit or then 
cpu -> c c@ 216 <> if 2 bit or then 
cpu -> d c@ 99 <> if 3 bit or then 
cpu -> e c@ 39 <> if 4 bit or then 
cpu -> f c@ 96 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 96 h.2 [char] ] emit space then 
cpu -> h c@ 240 <> if 6 bit or then 
cpu -> l c@ 190 <> if 7 bit or then 
cpu -> i_ c@ 202 <> if 8 bit or then 
cpu -> r c@ 94 <> if 9 bit or then 
cpu -> a_ c@ 153 <> cpu -> f_ c@ 137 <> or if 10 bit or then 
cpu -> b_ c@ 73 <> cpu -> c_ c@ 133 <> or if 11 bit or then 
cpu -> d_ c@ 180 <> cpu -> e_ c@ 210 <> or if 12 bit or then 
cpu -> h_ c@ 7 <> cpu -> l_ c@ 44 <> or if 13 bit or then 
cpu -> ix h@ 46089 <> if 14 bit or then 
cpu -> iy h@ 23837 <> if 15 bit or then 
cpu -> pc h@ 53209 <> if 16 bit or then 
cpu -> sp h@ 24836 <> if 17 bit or then 
cpu -> mem_ptr h@ 58366 <> if 18 bit or then 
53207 ram + c@ 221 <> if 19 bit or then 
53208 ram + c@ 66 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 42 0003 : " 
1138 cpu -> pc h! 42648 cpu -> sp h! 
4 cpu -> a c! 5 cpu -> b c! 167 cpu -> c c! 71 cpu -> d c! 
220 cpu -> e c! 134 cpu -> f c! 94 cpu -> h c! 143 cpu -> l c! 
240 cpu -> i_ c! 43 cpu -> r c! 5814 cpu -> mem_ptr h! 
28669 cpu -> ix h! 37693 cpu -> iy h! 
62 cpu -> a_ c! 91 cpu -> f_ c! 171 cpu -> b_ c! 4 cpu -> c_ c! 
9 cpu -> d_ c! 62 cpu -> e_ c! 124 cpu -> h_ c! 221 cpu -> l_ c! 
221 ram 1138 + c! 66 ram 1139 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 4 <> if 0 bit or then 
cpu -> b c@ 71 <> if 1 bit or then 
cpu -> c c@ 167 <> if 2 bit or then 
cpu -> d c@ 71 <> if 3 bit or then 
cpu -> e c@ 220 <> if 4 bit or then 
cpu -> f c@ 134 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 134 h.2 [char] ] emit space then 
cpu -> h c@ 94 <> if 6 bit or then 
cpu -> l c@ 143 <> if 7 bit or then 
cpu -> i_ c@ 240 <> if 8 bit or then 
cpu -> r c@ 45 <> if 9 bit or then 
cpu -> a_ c@ 62 <> cpu -> f_ c@ 91 <> or if 10 bit or then 
cpu -> b_ c@ 171 <> cpu -> c_ c@ 4 <> or if 11 bit or then 
cpu -> d_ c@ 9 <> cpu -> e_ c@ 62 <> or if 12 bit or then 
cpu -> h_ c@ 124 <> cpu -> l_ c@ 221 <> or if 13 bit or then 
cpu -> ix h@ 28669 <> if 14 bit or then 
cpu -> iy h@ 37693 <> if 15 bit or then 
cpu -> pc h@ 1140 <> if 16 bit or then 
cpu -> sp h@ 42648 <> if 17 bit or then 
cpu -> mem_ptr h@ 5814 <> if 18 bit or then 
1138 ram + c@ 221 <> if 19 bit or then 
1139 ram + c@ 66 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 42 0004 : " 
49134 cpu -> pc h! 9179 cpu -> sp h! 
52 cpu -> a c! 218 cpu -> b c! 40 cpu -> c c! 224 cpu -> d c! 
77 cpu -> e c! 227 cpu -> f c! 3 cpu -> h c! 152 cpu -> l c! 
171 cpu -> i_ c! 8 cpu -> r c! 348 cpu -> mem_ptr h! 
26485 cpu -> ix h! 51043 cpu -> iy h! 
89 cpu -> a_ c! 164 cpu -> f_ c! 229 cpu -> b_ c! 33 cpu -> c_ c! 
93 cpu -> d_ c! 245 cpu -> e_ c! 75 cpu -> h_ c! 221 cpu -> l_ c! 
221 ram 49134 + c! 66 ram 49135 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 52 <> if 0 bit or then 
cpu -> b c@ 224 <> if 1 bit or then 
cpu -> c c@ 40 <> if 2 bit or then 
cpu -> d c@ 224 <> if 3 bit or then 
cpu -> e c@ 77 <> if 4 bit or then 
cpu -> f c@ 227 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 227 h.2 [char] ] emit space then 
cpu -> h c@ 3 <> if 6 bit or then 
cpu -> l c@ 152 <> if 7 bit or then 
cpu -> i_ c@ 171 <> if 8 bit or then 
cpu -> r c@ 10 <> if 9 bit or then 
cpu -> a_ c@ 89 <> cpu -> f_ c@ 164 <> or if 10 bit or then 
cpu -> b_ c@ 229 <> cpu -> c_ c@ 33 <> or if 11 bit or then 
cpu -> d_ c@ 93 <> cpu -> e_ c@ 245 <> or if 12 bit or then 
cpu -> h_ c@ 75 <> cpu -> l_ c@ 221 <> or if 13 bit or then 
cpu -> ix h@ 26485 <> if 14 bit or then 
cpu -> iy h@ 51043 <> if 15 bit or then 
cpu -> pc h@ 49136 <> if 16 bit or then 
cpu -> sp h@ 9179 <> if 17 bit or then 
cpu -> mem_ptr h@ 348 <> if 18 bit or then 
49134 ram + c@ 221 <> if 19 bit or then 
49135 ram + c@ 66 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 43 0000 : " 
60423 cpu -> pc h! 7901 cpu -> sp h! 
193 cpu -> a c! 124 cpu -> b c! 239 cpu -> c c! 157 cpu -> d c! 
11 cpu -> e c! 223 cpu -> f c! 41 cpu -> h c! 61 cpu -> l c! 
182 cpu -> i_ c! 100 cpu -> r c! 50829 cpu -> mem_ptr h! 
41774 cpu -> ix h! 52720 cpu -> iy h! 
157 cpu -> a_ c! 65 cpu -> f_ c! 230 cpu -> b_ c! 165 cpu -> c_ c! 
251 cpu -> d_ c! 157 cpu -> e_ c! 179 cpu -> h_ c! 154 cpu -> l_ c! 
221 ram 60423 + c! 67 ram 60424 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 193 <> if 0 bit or then 
cpu -> b c@ 11 <> if 1 bit or then 
cpu -> c c@ 239 <> if 2 bit or then 
cpu -> d c@ 157 <> if 3 bit or then 
cpu -> e c@ 11 <> if 4 bit or then 
cpu -> f c@ 223 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 223 h.2 [char] ] emit space then 
cpu -> h c@ 41 <> if 6 bit or then 
cpu -> l c@ 61 <> if 7 bit or then 
cpu -> i_ c@ 182 <> if 8 bit or then 
cpu -> r c@ 102 <> if 9 bit or then 
cpu -> a_ c@ 157 <> cpu -> f_ c@ 65 <> or if 10 bit or then 
cpu -> b_ c@ 230 <> cpu -> c_ c@ 165 <> or if 11 bit or then 
cpu -> d_ c@ 251 <> cpu -> e_ c@ 157 <> or if 12 bit or then 
cpu -> h_ c@ 179 <> cpu -> l_ c@ 154 <> or if 13 bit or then 
cpu -> ix h@ 41774 <> if 14 bit or then 
cpu -> iy h@ 52720 <> if 15 bit or then 
cpu -> pc h@ 60425 <> if 16 bit or then 
cpu -> sp h@ 7901 <> if 17 bit or then 
cpu -> mem_ptr h@ 50829 <> if 18 bit or then 
60423 ram + c@ 221 <> if 19 bit or then 
60424 ram + c@ 67 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 43 0001 : " 
63018 cpu -> pc h! 20635 cpu -> sp h! 
235 cpu -> a c! 222 cpu -> b c! 46 cpu -> c c! 184 cpu -> d c! 
215 cpu -> e c! 37 cpu -> f c! 172 cpu -> h c! 163 cpu -> l c! 
178 cpu -> i_ c! 126 cpu -> r c! 39430 cpu -> mem_ptr h! 
11069 cpu -> ix h! 15636 cpu -> iy h! 
249 cpu -> a_ c! 157 cpu -> f_ c! 144 cpu -> b_ c! 192 cpu -> c_ c! 
71 cpu -> d_ c! 56 cpu -> e_ c! 20 cpu -> h_ c! 33 cpu -> l_ c! 
221 ram 63018 + c! 67 ram 63019 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 235 <> if 0 bit or then 
cpu -> b c@ 215 <> if 1 bit or then 
cpu -> c c@ 46 <> if 2 bit or then 
cpu -> d c@ 184 <> if 3 bit or then 
cpu -> e c@ 215 <> if 4 bit or then 
cpu -> f c@ 37 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 37 h.2 [char] ] emit space then 
cpu -> h c@ 172 <> if 6 bit or then 
cpu -> l c@ 163 <> if 7 bit or then 
cpu -> i_ c@ 178 <> if 8 bit or then 
cpu -> r c@ 0 <> if 9 bit or then 
cpu -> a_ c@ 249 <> cpu -> f_ c@ 157 <> or if 10 bit or then 
cpu -> b_ c@ 144 <> cpu -> c_ c@ 192 <> or if 11 bit or then 
cpu -> d_ c@ 71 <> cpu -> e_ c@ 56 <> or if 12 bit or then 
cpu -> h_ c@ 20 <> cpu -> l_ c@ 33 <> or if 13 bit or then 
cpu -> ix h@ 11069 <> if 14 bit or then 
cpu -> iy h@ 15636 <> if 15 bit or then 
cpu -> pc h@ 63020 <> if 16 bit or then 
cpu -> sp h@ 20635 <> if 17 bit or then 
cpu -> mem_ptr h@ 39430 <> if 18 bit or then 
63018 ram + c@ 221 <> if 19 bit or then 
63019 ram + c@ 67 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 43 0002 : " 
52712 cpu -> pc h! 21579 cpu -> sp h! 
153 cpu -> a c! 81 cpu -> b c! 188 cpu -> c c! 219 cpu -> d c! 
228 cpu -> e c! 196 cpu -> f c! 254 cpu -> h c! 11 cpu -> l c! 
91 cpu -> i_ c! 41 cpu -> r c! 7569 cpu -> mem_ptr h! 
29408 cpu -> ix h! 61983 cpu -> iy h! 
104 cpu -> a_ c! 12 cpu -> f_ c! 97 cpu -> b_ c! 56 cpu -> c_ c! 
131 cpu -> d_ c! 46 cpu -> e_ c! 247 cpu -> h_ c! 162 cpu -> l_ c! 
221 ram 52712 + c! 67 ram 52713 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 153 <> if 0 bit or then 
cpu -> b c@ 228 <> if 1 bit or then 
cpu -> c c@ 188 <> if 2 bit or then 
cpu -> d c@ 219 <> if 3 bit or then 
cpu -> e c@ 228 <> if 4 bit or then 
cpu -> f c@ 196 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 196 h.2 [char] ] emit space then 
cpu -> h c@ 254 <> if 6 bit or then 
cpu -> l c@ 11 <> if 7 bit or then 
cpu -> i_ c@ 91 <> if 8 bit or then 
cpu -> r c@ 43 <> if 9 bit or then 
cpu -> a_ c@ 104 <> cpu -> f_ c@ 12 <> or if 10 bit or then 
cpu -> b_ c@ 97 <> cpu -> c_ c@ 56 <> or if 11 bit or then 
cpu -> d_ c@ 131 <> cpu -> e_ c@ 46 <> or if 12 bit or then 
cpu -> h_ c@ 247 <> cpu -> l_ c@ 162 <> or if 13 bit or then 
cpu -> ix h@ 29408 <> if 14 bit or then 
cpu -> iy h@ 61983 <> if 15 bit or then 
cpu -> pc h@ 52714 <> if 16 bit or then 
cpu -> sp h@ 21579 <> if 17 bit or then 
cpu -> mem_ptr h@ 7569 <> if 18 bit or then 
52712 ram + c@ 221 <> if 19 bit or then 
52713 ram + c@ 67 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 43 0003 : " 
42975 cpu -> pc h! 1732 cpu -> sp h! 
23 cpu -> a c! 228 cpu -> b c! 111 cpu -> c c! 220 cpu -> d c! 
243 cpu -> e c! 199 cpu -> f c! 137 cpu -> h c! 48 cpu -> l c! 
99 cpu -> i_ c! 94 cpu -> r c! 20123 cpu -> mem_ptr h! 
64424 cpu -> ix h! 34292 cpu -> iy h! 
133 cpu -> a_ c! 102 cpu -> f_ c! 117 cpu -> b_ c! 114 cpu -> c_ c! 
176 cpu -> d_ c! 91 cpu -> e_ c! 9 cpu -> h_ c! 0 cpu -> l_ c! 
221 ram 42975 + c! 67 ram 42976 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 23 <> if 0 bit or then 
cpu -> b c@ 243 <> if 1 bit or then 
cpu -> c c@ 111 <> if 2 bit or then 
cpu -> d c@ 220 <> if 3 bit or then 
cpu -> e c@ 243 <> if 4 bit or then 
cpu -> f c@ 199 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 199 h.2 [char] ] emit space then 
cpu -> h c@ 137 <> if 6 bit or then 
cpu -> l c@ 48 <> if 7 bit or then 
cpu -> i_ c@ 99 <> if 8 bit or then 
cpu -> r c@ 96 <> if 9 bit or then 
cpu -> a_ c@ 133 <> cpu -> f_ c@ 102 <> or if 10 bit or then 
cpu -> b_ c@ 117 <> cpu -> c_ c@ 114 <> or if 11 bit or then 
cpu -> d_ c@ 176 <> cpu -> e_ c@ 91 <> or if 12 bit or then 
cpu -> h_ c@ 9 <> cpu -> l_ c@ 0 <> or if 13 bit or then 
cpu -> ix h@ 64424 <> if 14 bit or then 
cpu -> iy h@ 34292 <> if 15 bit or then 
cpu -> pc h@ 42977 <> if 16 bit or then 
cpu -> sp h@ 1732 <> if 17 bit or then 
cpu -> mem_ptr h@ 20123 <> if 18 bit or then 
42975 ram + c@ 221 <> if 19 bit or then 
42976 ram + c@ 67 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 43 0004 : " 
372 cpu -> pc h! 15469 cpu -> sp h! 
169 cpu -> a c! 93 cpu -> b c! 116 cpu -> c c! 109 cpu -> d c! 
173 cpu -> e c! 234 cpu -> f c! 69 cpu -> h c! 53 cpu -> l c! 
226 cpu -> i_ c! 32 cpu -> r c! 3845 cpu -> mem_ptr h! 
19352 cpu -> ix h! 64977 cpu -> iy h! 
221 cpu -> a_ c! 221 cpu -> f_ c! 142 cpu -> b_ c! 145 cpu -> c_ c! 
159 cpu -> d_ c! 113 cpu -> e_ c! 16 cpu -> h_ c! 159 cpu -> l_ c! 
221 ram 372 + c! 67 ram 373 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 169 <> if 0 bit or then 
cpu -> b c@ 173 <> if 1 bit or then 
cpu -> c c@ 116 <> if 2 bit or then 
cpu -> d c@ 109 <> if 3 bit or then 
cpu -> e c@ 173 <> if 4 bit or then 
cpu -> f c@ 234 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 234 h.2 [char] ] emit space then 
cpu -> h c@ 69 <> if 6 bit or then 
cpu -> l c@ 53 <> if 7 bit or then 
cpu -> i_ c@ 226 <> if 8 bit or then 
cpu -> r c@ 34 <> if 9 bit or then 
cpu -> a_ c@ 221 <> cpu -> f_ c@ 221 <> or if 10 bit or then 
cpu -> b_ c@ 142 <> cpu -> c_ c@ 145 <> or if 11 bit or then 
cpu -> d_ c@ 159 <> cpu -> e_ c@ 113 <> or if 12 bit or then 
cpu -> h_ c@ 16 <> cpu -> l_ c@ 159 <> or if 13 bit or then 
cpu -> ix h@ 19352 <> if 14 bit or then 
cpu -> iy h@ 64977 <> if 15 bit or then 
cpu -> pc h@ 374 <> if 16 bit or then 
cpu -> sp h@ 15469 <> if 17 bit or then 
cpu -> mem_ptr h@ 3845 <> if 18 bit or then 
372 ram + c@ 221 <> if 19 bit or then 
373 ram + c@ 67 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 44 0000 : " 
16186 cpu -> pc h! 6141 cpu -> sp h! 
15 cpu -> a c! 76 cpu -> b c! 101 cpu -> c c! 150 cpu -> d c! 
121 cpu -> e c! 234 cpu -> f c! 116 cpu -> h c! 36 cpu -> l c! 
90 cpu -> i_ c! 106 cpu -> r c! 28514 cpu -> mem_ptr h! 
8276 cpu -> ix h! 59596 cpu -> iy h! 
216 cpu -> a_ c! 86 cpu -> f_ c! 39 cpu -> b_ c! 110 cpu -> c_ c! 
19 cpu -> d_ c! 106 cpu -> e_ c! 63 cpu -> h_ c! 150 cpu -> l_ c! 
221 ram 16186 + c! 68 ram 16187 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 15 <> if 0 bit or then 
cpu -> b c@ 32 <> if 1 bit or then 
cpu -> c c@ 101 <> if 2 bit or then 
cpu -> d c@ 150 <> if 3 bit or then 
cpu -> e c@ 121 <> if 4 bit or then 
cpu -> f c@ 234 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 234 h.2 [char] ] emit space then 
cpu -> h c@ 116 <> if 6 bit or then 
cpu -> l c@ 36 <> if 7 bit or then 
cpu -> i_ c@ 90 <> if 8 bit or then 
cpu -> r c@ 108 <> if 9 bit or then 
cpu -> a_ c@ 216 <> cpu -> f_ c@ 86 <> or if 10 bit or then 
cpu -> b_ c@ 39 <> cpu -> c_ c@ 110 <> or if 11 bit or then 
cpu -> d_ c@ 19 <> cpu -> e_ c@ 106 <> or if 12 bit or then 
cpu -> h_ c@ 63 <> cpu -> l_ c@ 150 <> or if 13 bit or then 
cpu -> ix h@ 8276 <> if 14 bit or then 
cpu -> iy h@ 59596 <> if 15 bit or then 
cpu -> pc h@ 16188 <> if 16 bit or then 
cpu -> sp h@ 6141 <> if 17 bit or then 
cpu -> mem_ptr h@ 28514 <> if 18 bit or then 
16186 ram + c@ 221 <> if 19 bit or then 
16187 ram + c@ 68 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 44 0001 : " 
40546 cpu -> pc h! 33082 cpu -> sp h! 
103 cpu -> a c! 106 cpu -> b c! 216 cpu -> c c! 117 cpu -> d c! 
47 cpu -> e c! 253 cpu -> f c! 49 cpu -> h c! 23 cpu -> l c! 
239 cpu -> i_ c! 111 cpu -> r c! 39305 cpu -> mem_ptr h! 
29015 cpu -> ix h! 47794 cpu -> iy h! 
53 cpu -> a_ c! 43 cpu -> f_ c! 84 cpu -> b_ c! 93 cpu -> c_ c! 
251 cpu -> d_ c! 75 cpu -> e_ c! 200 cpu -> h_ c! 102 cpu -> l_ c! 
221 ram 40546 + c! 68 ram 40547 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 103 <> if 0 bit or then 
cpu -> b c@ 113 <> if 1 bit or then 
cpu -> c c@ 216 <> if 2 bit or then 
cpu -> d c@ 117 <> if 3 bit or then 
cpu -> e c@ 47 <> if 4 bit or then 
cpu -> f c@ 253 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 253 h.2 [char] ] emit space then 
cpu -> h c@ 49 <> if 6 bit or then 
cpu -> l c@ 23 <> if 7 bit or then 
cpu -> i_ c@ 239 <> if 8 bit or then 
cpu -> r c@ 113 <> if 9 bit or then 
cpu -> a_ c@ 53 <> cpu -> f_ c@ 43 <> or if 10 bit or then 
cpu -> b_ c@ 84 <> cpu -> c_ c@ 93 <> or if 11 bit or then 
cpu -> d_ c@ 251 <> cpu -> e_ c@ 75 <> or if 12 bit or then 
cpu -> h_ c@ 200 <> cpu -> l_ c@ 102 <> or if 13 bit or then 
cpu -> ix h@ 29015 <> if 14 bit or then 
cpu -> iy h@ 47794 <> if 15 bit or then 
cpu -> pc h@ 40548 <> if 16 bit or then 
cpu -> sp h@ 33082 <> if 17 bit or then 
cpu -> mem_ptr h@ 39305 <> if 18 bit or then 
40546 ram + c@ 221 <> if 19 bit or then 
40547 ram + c@ 68 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 44 0002 : " 
4088 cpu -> pc h! 21080 cpu -> sp h! 
84 cpu -> a c! 153 cpu -> b c! 68 cpu -> c c! 215 cpu -> d c! 
234 cpu -> e c! 43 cpu -> f c! 4 cpu -> h c! 252 cpu -> l c! 
144 cpu -> i_ c! 67 cpu -> r c! 10940 cpu -> mem_ptr h! 
36844 cpu -> ix h! 58183 cpu -> iy h! 
41 cpu -> a_ c! 209 cpu -> f_ c! 21 cpu -> b_ c! 208 cpu -> c_ c! 
131 cpu -> d_ c! 217 cpu -> e_ c! 220 cpu -> h_ c! 172 cpu -> l_ c! 
221 ram 4088 + c! 68 ram 4089 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 84 <> if 0 bit or then 
cpu -> b c@ 143 <> if 1 bit or then 
cpu -> c c@ 68 <> if 2 bit or then 
cpu -> d c@ 215 <> if 3 bit or then 
cpu -> e c@ 234 <> if 4 bit or then 
cpu -> f c@ 43 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 43 h.2 [char] ] emit space then 
cpu -> h c@ 4 <> if 6 bit or then 
cpu -> l c@ 252 <> if 7 bit or then 
cpu -> i_ c@ 144 <> if 8 bit or then 
cpu -> r c@ 69 <> if 9 bit or then 
cpu -> a_ c@ 41 <> cpu -> f_ c@ 209 <> or if 10 bit or then 
cpu -> b_ c@ 21 <> cpu -> c_ c@ 208 <> or if 11 bit or then 
cpu -> d_ c@ 131 <> cpu -> e_ c@ 217 <> or if 12 bit or then 
cpu -> h_ c@ 220 <> cpu -> l_ c@ 172 <> or if 13 bit or then 
cpu -> ix h@ 36844 <> if 14 bit or then 
cpu -> iy h@ 58183 <> if 15 bit or then 
cpu -> pc h@ 4090 <> if 16 bit or then 
cpu -> sp h@ 21080 <> if 17 bit or then 
cpu -> mem_ptr h@ 10940 <> if 18 bit or then 
4088 ram + c@ 221 <> if 19 bit or then 
4089 ram + c@ 68 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 44 0003 : " 
29003 cpu -> pc h! 6982 cpu -> sp h! 
0 cpu -> a c! 192 cpu -> b c! 99 cpu -> c c! 57 cpu -> d c! 
225 cpu -> e c! 139 cpu -> f c! 29 cpu -> h c! 254 cpu -> l c! 
47 cpu -> i_ c! 79 cpu -> r c! 49058 cpu -> mem_ptr h! 
55914 cpu -> ix h! 61007 cpu -> iy h! 
21 cpu -> a_ c! 19 cpu -> f_ c! 185 cpu -> b_ c! 131 cpu -> c_ c! 
43 cpu -> d_ c! 243 cpu -> e_ c! 104 cpu -> h_ c! 212 cpu -> l_ c! 
221 ram 29003 + c! 68 ram 29004 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 0 <> if 0 bit or then 
cpu -> b c@ 218 <> if 1 bit or then 
cpu -> c c@ 99 <> if 2 bit or then 
cpu -> d c@ 57 <> if 3 bit or then 
cpu -> e c@ 225 <> if 4 bit or then 
cpu -> f c@ 139 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 139 h.2 [char] ] emit space then 
cpu -> h c@ 29 <> if 6 bit or then 
cpu -> l c@ 254 <> if 7 bit or then 
cpu -> i_ c@ 47 <> if 8 bit or then 
cpu -> r c@ 81 <> if 9 bit or then 
cpu -> a_ c@ 21 <> cpu -> f_ c@ 19 <> or if 10 bit or then 
cpu -> b_ c@ 185 <> cpu -> c_ c@ 131 <> or if 11 bit or then 
cpu -> d_ c@ 43 <> cpu -> e_ c@ 243 <> or if 12 bit or then 
cpu -> h_ c@ 104 <> cpu -> l_ c@ 212 <> or if 13 bit or then 
cpu -> ix h@ 55914 <> if 14 bit or then 
cpu -> iy h@ 61007 <> if 15 bit or then 
cpu -> pc h@ 29005 <> if 16 bit or then 
cpu -> sp h@ 6982 <> if 17 bit or then 
cpu -> mem_ptr h@ 49058 <> if 18 bit or then 
29003 ram + c@ 221 <> if 19 bit or then 
29004 ram + c@ 68 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 44 0004 : " 
33093 cpu -> pc h! 34523 cpu -> sp h! 
193 cpu -> a c! 47 cpu -> b c! 244 cpu -> c c! 192 cpu -> d c! 
40 cpu -> e c! 232 cpu -> f c! 122 cpu -> h c! 240 cpu -> l c! 
39 cpu -> i_ c! 3 cpu -> r c! 6202 cpu -> mem_ptr h! 
45318 cpu -> ix h! 43603 cpu -> iy h! 
161 cpu -> a_ c! 221 cpu -> f_ c! 246 cpu -> b_ c! 85 cpu -> c_ c! 
58 cpu -> d_ c! 205 cpu -> e_ c! 171 cpu -> h_ c! 130 cpu -> l_ c! 
221 ram 33093 + c! 68 ram 33094 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 193 <> if 0 bit or then 
cpu -> b c@ 177 <> if 1 bit or then 
cpu -> c c@ 244 <> if 2 bit or then 
cpu -> d c@ 192 <> if 3 bit or then 
cpu -> e c@ 40 <> if 4 bit or then 
cpu -> f c@ 232 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 232 h.2 [char] ] emit space then 
cpu -> h c@ 122 <> if 6 bit or then 
cpu -> l c@ 240 <> if 7 bit or then 
cpu -> i_ c@ 39 <> if 8 bit or then 
cpu -> r c@ 5 <> if 9 bit or then 
cpu -> a_ c@ 161 <> cpu -> f_ c@ 221 <> or if 10 bit or then 
cpu -> b_ c@ 246 <> cpu -> c_ c@ 85 <> or if 11 bit or then 
cpu -> d_ c@ 58 <> cpu -> e_ c@ 205 <> or if 12 bit or then 
cpu -> h_ c@ 171 <> cpu -> l_ c@ 130 <> or if 13 bit or then 
cpu -> ix h@ 45318 <> if 14 bit or then 
cpu -> iy h@ 43603 <> if 15 bit or then 
cpu -> pc h@ 33095 <> if 16 bit or then 
cpu -> sp h@ 34523 <> if 17 bit or then 
cpu -> mem_ptr h@ 6202 <> if 18 bit or then 
33093 ram + c@ 221 <> if 19 bit or then 
33094 ram + c@ 68 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 45 0000 : " 
17757 cpu -> pc h! 30262 cpu -> sp h! 
18 cpu -> a c! 12 cpu -> b c! 199 cpu -> c c! 98 cpu -> d c! 
205 cpu -> e c! 50 cpu -> f c! 250 cpu -> h c! 31 cpu -> l c! 
211 cpu -> i_ c! 63 cpu -> r c! 58842 cpu -> mem_ptr h! 
14926 cpu -> ix h! 31140 cpu -> iy h! 
197 cpu -> a_ c! 3 cpu -> f_ c! 28 cpu -> b_ c! 133 cpu -> c_ c! 
20 cpu -> d_ c! 203 cpu -> e_ c! 102 cpu -> h_ c! 219 cpu -> l_ c! 
221 ram 17757 + c! 69 ram 17758 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 18 <> if 0 bit or then 
cpu -> b c@ 78 <> if 1 bit or then 
cpu -> c c@ 199 <> if 2 bit or then 
cpu -> d c@ 98 <> if 3 bit or then 
cpu -> e c@ 205 <> if 4 bit or then 
cpu -> f c@ 50 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 50 h.2 [char] ] emit space then 
cpu -> h c@ 250 <> if 6 bit or then 
cpu -> l c@ 31 <> if 7 bit or then 
cpu -> i_ c@ 211 <> if 8 bit or then 
cpu -> r c@ 65 <> if 9 bit or then 
cpu -> a_ c@ 197 <> cpu -> f_ c@ 3 <> or if 10 bit or then 
cpu -> b_ c@ 28 <> cpu -> c_ c@ 133 <> or if 11 bit or then 
cpu -> d_ c@ 20 <> cpu -> e_ c@ 203 <> or if 12 bit or then 
cpu -> h_ c@ 102 <> cpu -> l_ c@ 219 <> or if 13 bit or then 
cpu -> ix h@ 14926 <> if 14 bit or then 
cpu -> iy h@ 31140 <> if 15 bit or then 
cpu -> pc h@ 17759 <> if 16 bit or then 
cpu -> sp h@ 30262 <> if 17 bit or then 
cpu -> mem_ptr h@ 58842 <> if 18 bit or then 
17757 ram + c@ 221 <> if 19 bit or then 
17758 ram + c@ 69 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 45 0001 : " 
17636 cpu -> pc h! 25056 cpu -> sp h! 
80 cpu -> a c! 246 cpu -> b c! 5 cpu -> c c! 226 cpu -> d c! 
113 cpu -> e c! 171 cpu -> f c! 10 cpu -> h c! 210 cpu -> l c! 
172 cpu -> i_ c! 100 cpu -> r c! 24587 cpu -> mem_ptr h! 
13643 cpu -> ix h! 27190 cpu -> iy h! 
145 cpu -> a_ c! 190 cpu -> f_ c! 245 cpu -> b_ c! 189 cpu -> c_ c! 
23 cpu -> d_ c! 45 cpu -> e_ c! 229 cpu -> h_ c! 4 cpu -> l_ c! 
221 ram 17636 + c! 69 ram 17637 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 80 <> if 0 bit or then 
cpu -> b c@ 75 <> if 1 bit or then 
cpu -> c c@ 5 <> if 2 bit or then 
cpu -> d c@ 226 <> if 3 bit or then 
cpu -> e c@ 113 <> if 4 bit or then 
cpu -> f c@ 171 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 171 h.2 [char] ] emit space then 
cpu -> h c@ 10 <> if 6 bit or then 
cpu -> l c@ 210 <> if 7 bit or then 
cpu -> i_ c@ 172 <> if 8 bit or then 
cpu -> r c@ 102 <> if 9 bit or then 
cpu -> a_ c@ 145 <> cpu -> f_ c@ 190 <> or if 10 bit or then 
cpu -> b_ c@ 245 <> cpu -> c_ c@ 189 <> or if 11 bit or then 
cpu -> d_ c@ 23 <> cpu -> e_ c@ 45 <> or if 12 bit or then 
cpu -> h_ c@ 229 <> cpu -> l_ c@ 4 <> or if 13 bit or then 
cpu -> ix h@ 13643 <> if 14 bit or then 
cpu -> iy h@ 27190 <> if 15 bit or then 
cpu -> pc h@ 17638 <> if 16 bit or then 
cpu -> sp h@ 25056 <> if 17 bit or then 
cpu -> mem_ptr h@ 24587 <> if 18 bit or then 
17636 ram + c@ 221 <> if 19 bit or then 
17637 ram + c@ 69 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 45 0002 : " 
38440 cpu -> pc h! 63184 cpu -> sp h! 
117 cpu -> a c! 181 cpu -> b c! 29 cpu -> c c! 128 cpu -> d c! 
155 cpu -> e c! 42 cpu -> f c! 192 cpu -> h c! 77 cpu -> l c! 
241 cpu -> i_ c! 3 cpu -> r c! 4944 cpu -> mem_ptr h! 
45732 cpu -> ix h! 25444 cpu -> iy h! 
206 cpu -> a_ c! 174 cpu -> f_ c! 73 cpu -> b_ c! 141 cpu -> c_ c! 
153 cpu -> d_ c! 134 cpu -> e_ c! 235 cpu -> h_ c! 57 cpu -> l_ c! 
221 ram 38440 + c! 69 ram 38441 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 117 <> if 0 bit or then 
cpu -> b c@ 164 <> if 1 bit or then 
cpu -> c c@ 29 <> if 2 bit or then 
cpu -> d c@ 128 <> if 3 bit or then 
cpu -> e c@ 155 <> if 4 bit or then 
cpu -> f c@ 42 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 42 h.2 [char] ] emit space then 
cpu -> h c@ 192 <> if 6 bit or then 
cpu -> l c@ 77 <> if 7 bit or then 
cpu -> i_ c@ 241 <> if 8 bit or then 
cpu -> r c@ 5 <> if 9 bit or then 
cpu -> a_ c@ 206 <> cpu -> f_ c@ 174 <> or if 10 bit or then 
cpu -> b_ c@ 73 <> cpu -> c_ c@ 141 <> or if 11 bit or then 
cpu -> d_ c@ 153 <> cpu -> e_ c@ 134 <> or if 12 bit or then 
cpu -> h_ c@ 235 <> cpu -> l_ c@ 57 <> or if 13 bit or then 
cpu -> ix h@ 45732 <> if 14 bit or then 
cpu -> iy h@ 25444 <> if 15 bit or then 
cpu -> pc h@ 38442 <> if 16 bit or then 
cpu -> sp h@ 63184 <> if 17 bit or then 
cpu -> mem_ptr h@ 4944 <> if 18 bit or then 
38440 ram + c@ 221 <> if 19 bit or then 
38441 ram + c@ 69 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 45 0003 : " 
7553 cpu -> pc h! 58453 cpu -> sp h! 
29 cpu -> a c! 226 cpu -> b c! 113 cpu -> c c! 71 cpu -> d c! 
252 cpu -> e c! 134 cpu -> f c! 127 cpu -> h c! 187 cpu -> l c! 
31 cpu -> i_ c! 31 cpu -> r c! 59824 cpu -> mem_ptr h! 
18152 cpu -> ix h! 27649 cpu -> iy h! 
205 cpu -> a_ c! 150 cpu -> f_ c! 40 cpu -> b_ c! 25 cpu -> c_ c! 
163 cpu -> d_ c! 46 cpu -> e_ c! 57 cpu -> h_ c! 23 cpu -> l_ c! 
221 ram 7553 + c! 69 ram 7554 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 29 <> if 0 bit or then 
cpu -> b c@ 232 <> if 1 bit or then 
cpu -> c c@ 113 <> if 2 bit or then 
cpu -> d c@ 71 <> if 3 bit or then 
cpu -> e c@ 252 <> if 4 bit or then 
cpu -> f c@ 134 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 134 h.2 [char] ] emit space then 
cpu -> h c@ 127 <> if 6 bit or then 
cpu -> l c@ 187 <> if 7 bit or then 
cpu -> i_ c@ 31 <> if 8 bit or then 
cpu -> r c@ 33 <> if 9 bit or then 
cpu -> a_ c@ 205 <> cpu -> f_ c@ 150 <> or if 10 bit or then 
cpu -> b_ c@ 40 <> cpu -> c_ c@ 25 <> or if 11 bit or then 
cpu -> d_ c@ 163 <> cpu -> e_ c@ 46 <> or if 12 bit or then 
cpu -> h_ c@ 57 <> cpu -> l_ c@ 23 <> or if 13 bit or then 
cpu -> ix h@ 18152 <> if 14 bit or then 
cpu -> iy h@ 27649 <> if 15 bit or then 
cpu -> pc h@ 7555 <> if 16 bit or then 
cpu -> sp h@ 58453 <> if 17 bit or then 
cpu -> mem_ptr h@ 59824 <> if 18 bit or then 
7553 ram + c@ 221 <> if 19 bit or then 
7554 ram + c@ 69 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 45 0004 : " 
38806 cpu -> pc h! 33663 cpu -> sp h! 
0 cpu -> a c! 193 cpu -> b c! 85 cpu -> c c! 79 cpu -> d c! 
97 cpu -> e c! 95 cpu -> f c! 154 cpu -> h c! 17 cpu -> l c! 
131 cpu -> i_ c! 85 cpu -> r c! 9137 cpu -> mem_ptr h! 
40336 cpu -> ix h! 868 cpu -> iy h! 
55 cpu -> a_ c! 182 cpu -> f_ c! 149 cpu -> b_ c! 21 cpu -> c_ c! 
78 cpu -> d_ c! 119 cpu -> e_ c! 4 cpu -> h_ c! 192 cpu -> l_ c! 
221 ram 38806 + c! 69 ram 38807 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 0 <> if 0 bit or then 
cpu -> b c@ 144 <> if 1 bit or then 
cpu -> c c@ 85 <> if 2 bit or then 
cpu -> d c@ 79 <> if 3 bit or then 
cpu -> e c@ 97 <> if 4 bit or then 
cpu -> f c@ 95 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 95 h.2 [char] ] emit space then 
cpu -> h c@ 154 <> if 6 bit or then 
cpu -> l c@ 17 <> if 7 bit or then 
cpu -> i_ c@ 131 <> if 8 bit or then 
cpu -> r c@ 87 <> if 9 bit or then 
cpu -> a_ c@ 55 <> cpu -> f_ c@ 182 <> or if 10 bit or then 
cpu -> b_ c@ 149 <> cpu -> c_ c@ 21 <> or if 11 bit or then 
cpu -> d_ c@ 78 <> cpu -> e_ c@ 119 <> or if 12 bit or then 
cpu -> h_ c@ 4 <> cpu -> l_ c@ 192 <> or if 13 bit or then 
cpu -> ix h@ 40336 <> if 14 bit or then 
cpu -> iy h@ 868 <> if 15 bit or then 
cpu -> pc h@ 38808 <> if 16 bit or then 
cpu -> sp h@ 33663 <> if 17 bit or then 
cpu -> mem_ptr h@ 9137 <> if 18 bit or then 
38806 ram + c@ 221 <> if 19 bit or then 
38807 ram + c@ 69 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 46 0000 : " 
31724 cpu -> pc h! 49796 cpu -> sp h! 
42 cpu -> a c! 144 cpu -> b c! 65 cpu -> c c! 248 cpu -> d c! 
10 cpu -> e c! 170 cpu -> f c! 0 cpu -> h c! 36 cpu -> l c! 
164 cpu -> i_ c! 0 cpu -> r c! 48514 cpu -> mem_ptr h! 
50122 cpu -> ix h! 60868 cpu -> iy h! 
198 cpu -> a_ c! 15 cpu -> f_ c! 8 cpu -> b_ c! 9 cpu -> c_ c! 
54 cpu -> d_ c! 58 cpu -> e_ c! 117 cpu -> h_ c! 6 cpu -> l_ c! 
221 ram 31724 + c! 70 ram 31725 + c! 75 ram 31726 + c! 115 ram 50197 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 42 <> if 0 bit or then 
cpu -> b c@ 115 <> if 1 bit or then 
cpu -> c c@ 65 <> if 2 bit or then 
cpu -> d c@ 248 <> if 3 bit or then 
cpu -> e c@ 10 <> if 4 bit or then 
cpu -> f c@ 170 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 170 h.2 [char] ] emit space then 
cpu -> h c@ 0 <> if 6 bit or then 
cpu -> l c@ 36 <> if 7 bit or then 
cpu -> i_ c@ 164 <> if 8 bit or then 
cpu -> r c@ 2 <> if 9 bit or then 
cpu -> a_ c@ 198 <> cpu -> f_ c@ 15 <> or if 10 bit or then 
cpu -> b_ c@ 8 <> cpu -> c_ c@ 9 <> or if 11 bit or then 
cpu -> d_ c@ 54 <> cpu -> e_ c@ 58 <> or if 12 bit or then 
cpu -> h_ c@ 117 <> cpu -> l_ c@ 6 <> or if 13 bit or then 
cpu -> ix h@ 50122 <> if 14 bit or then 
cpu -> iy h@ 60868 <> if 15 bit or then 
cpu -> pc h@ 31727 <> if 16 bit or then 
cpu -> sp h@ 49796 <> if 17 bit or then 
cpu -> mem_ptr h@ 50197 <> if 18 bit or then 
31724 ram + c@ 221 <> if 19 bit or then 
31725 ram + c@ 70 <> if 19 bit or then 
31726 ram + c@ 75 <> if 19 bit or then 
50197 ram + c@ 115 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 46 0001 : " 
5596 cpu -> pc h! 42275 cpu -> sp h! 
91 cpu -> a c! 86 cpu -> b c! 126 cpu -> c c! 183 cpu -> d c! 
220 cpu -> e c! 92 cpu -> f c! 129 cpu -> h c! 199 cpu -> l c! 
9 cpu -> i_ c! 74 cpu -> r c! 13963 cpu -> mem_ptr h! 
17013 cpu -> ix h! 20623 cpu -> iy h! 
120 cpu -> a_ c! 79 cpu -> f_ c! 48 cpu -> b_ c! 228 cpu -> c_ c! 
17 cpu -> d_ c! 134 cpu -> e_ c! 123 cpu -> h_ c! 220 cpu -> l_ c! 
221 ram 5596 + c! 70 ram 5597 + c! 250 ram 5598 + c! 44 ram 17007 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 91 <> if 0 bit or then 
cpu -> b c@ 44 <> if 1 bit or then 
cpu -> c c@ 126 <> if 2 bit or then 
cpu -> d c@ 183 <> if 3 bit or then 
cpu -> e c@ 220 <> if 4 bit or then 
cpu -> f c@ 92 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 92 h.2 [char] ] emit space then 
cpu -> h c@ 129 <> if 6 bit or then 
cpu -> l c@ 199 <> if 7 bit or then 
cpu -> i_ c@ 9 <> if 8 bit or then 
cpu -> r c@ 76 <> if 9 bit or then 
cpu -> a_ c@ 120 <> cpu -> f_ c@ 79 <> or if 10 bit or then 
cpu -> b_ c@ 48 <> cpu -> c_ c@ 228 <> or if 11 bit or then 
cpu -> d_ c@ 17 <> cpu -> e_ c@ 134 <> or if 12 bit or then 
cpu -> h_ c@ 123 <> cpu -> l_ c@ 220 <> or if 13 bit or then 
cpu -> ix h@ 17013 <> if 14 bit or then 
cpu -> iy h@ 20623 <> if 15 bit or then 
cpu -> pc h@ 5599 <> if 16 bit or then 
cpu -> sp h@ 42275 <> if 17 bit or then 
cpu -> mem_ptr h@ 17007 <> if 18 bit or then 
5596 ram + c@ 221 <> if 19 bit or then 
5597 ram + c@ 70 <> if 19 bit or then 
5598 ram + c@ 250 <> if 19 bit or then 
17007 ram + c@ 44 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 46 0002 : " 
63858 cpu -> pc h! 21810 cpu -> sp h! 
173 cpu -> a c! 232 cpu -> b c! 253 cpu -> c c! 88 cpu -> d c! 
164 cpu -> e c! 133 cpu -> f c! 218 cpu -> h c! 231 cpu -> l c! 
64 cpu -> i_ c! 42 cpu -> r c! 9126 cpu -> mem_ptr h! 
41047 cpu -> ix h! 64806 cpu -> iy h! 
160 cpu -> a_ c! 178 cpu -> f_ c! 204 cpu -> b_ c! 49 cpu -> c_ c! 
61 cpu -> d_ c! 0 cpu -> e_ c! 28 cpu -> h_ c! 43 cpu -> l_ c! 
166 ram 40971 + c! 221 ram 63858 + c! 70 ram 63859 + c! 180 ram 63860 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 173 <> if 0 bit or then 
cpu -> b c@ 166 <> if 1 bit or then 
cpu -> c c@ 253 <> if 2 bit or then 
cpu -> d c@ 88 <> if 3 bit or then 
cpu -> e c@ 164 <> if 4 bit or then 
cpu -> f c@ 133 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 133 h.2 [char] ] emit space then 
cpu -> h c@ 218 <> if 6 bit or then 
cpu -> l c@ 231 <> if 7 bit or then 
cpu -> i_ c@ 64 <> if 8 bit or then 
cpu -> r c@ 44 <> if 9 bit or then 
cpu -> a_ c@ 160 <> cpu -> f_ c@ 178 <> or if 10 bit or then 
cpu -> b_ c@ 204 <> cpu -> c_ c@ 49 <> or if 11 bit or then 
cpu -> d_ c@ 61 <> cpu -> e_ c@ 0 <> or if 12 bit or then 
cpu -> h_ c@ 28 <> cpu -> l_ c@ 43 <> or if 13 bit or then 
cpu -> ix h@ 41047 <> if 14 bit or then 
cpu -> iy h@ 64806 <> if 15 bit or then 
cpu -> pc h@ 63861 <> if 16 bit or then 
cpu -> sp h@ 21810 <> if 17 bit or then 
cpu -> mem_ptr h@ 40971 <> if 18 bit or then 
40971 ram + c@ 166 <> if 19 bit or then 
63858 ram + c@ 221 <> if 19 bit or then 
63859 ram + c@ 70 <> if 19 bit or then 
63860 ram + c@ 180 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 46 0003 : " 
51274 cpu -> pc h! 34686 cpu -> sp h! 
75 cpu -> a c! 239 cpu -> b c! 1 cpu -> c c! 235 cpu -> d c! 
21 cpu -> e c! 155 cpu -> f c! 43 cpu -> h c! 43 cpu -> l c! 
139 cpu -> i_ c! 40 cpu -> r c! 21239 cpu -> mem_ptr h! 
48305 cpu -> ix h! 8185 cpu -> iy h! 
225 cpu -> a_ c! 50 cpu -> f_ c! 107 cpu -> b_ c! 3 cpu -> c_ c! 
3 cpu -> d_ c! 46 cpu -> e_ c! 120 cpu -> h_ c! 244 cpu -> l_ c! 
221 ram 48220 + c! 221 ram 51274 + c! 70 ram 51275 + c! 171 ram 51276 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 75 <> if 0 bit or then 
cpu -> b c@ 221 <> if 1 bit or then 
cpu -> c c@ 1 <> if 2 bit or then 
cpu -> d c@ 235 <> if 3 bit or then 
cpu -> e c@ 21 <> if 4 bit or then 
cpu -> f c@ 155 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 155 h.2 [char] ] emit space then 
cpu -> h c@ 43 <> if 6 bit or then 
cpu -> l c@ 43 <> if 7 bit or then 
cpu -> i_ c@ 139 <> if 8 bit or then 
cpu -> r c@ 42 <> if 9 bit or then 
cpu -> a_ c@ 225 <> cpu -> f_ c@ 50 <> or if 10 bit or then 
cpu -> b_ c@ 107 <> cpu -> c_ c@ 3 <> or if 11 bit or then 
cpu -> d_ c@ 3 <> cpu -> e_ c@ 46 <> or if 12 bit or then 
cpu -> h_ c@ 120 <> cpu -> l_ c@ 244 <> or if 13 bit or then 
cpu -> ix h@ 48305 <> if 14 bit or then 
cpu -> iy h@ 8185 <> if 15 bit or then 
cpu -> pc h@ 51277 <> if 16 bit or then 
cpu -> sp h@ 34686 <> if 17 bit or then 
cpu -> mem_ptr h@ 48220 <> if 18 bit or then 
48220 ram + c@ 221 <> if 19 bit or then 
51274 ram + c@ 221 <> if 19 bit or then 
51275 ram + c@ 70 <> if 19 bit or then 
51276 ram + c@ 171 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 46 0004 : " 
47943 cpu -> pc h! 10948 cpu -> sp h! 
250 cpu -> a c! 93 cpu -> b c! 188 cpu -> c c! 215 cpu -> d c! 
25 cpu -> e c! 245 cpu -> f c! 35 cpu -> h c! 138 cpu -> l c! 
125 cpu -> i_ c! 36 cpu -> r c! 47202 cpu -> mem_ptr h! 
5220 cpu -> ix h! 23753 cpu -> iy h! 
243 cpu -> a_ c! 159 cpu -> f_ c! 39 cpu -> b_ c! 123 cpu -> c_ c! 
213 cpu -> d_ c! 73 cpu -> e_ c! 78 cpu -> h_ c! 35 cpu -> l_ c! 
164 ram 5228 + c! 221 ram 47943 + c! 70 ram 47944 + c! 8 ram 47945 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 250 <> if 0 bit or then 
cpu -> b c@ 164 <> if 1 bit or then 
cpu -> c c@ 188 <> if 2 bit or then 
cpu -> d c@ 215 <> if 3 bit or then 
cpu -> e c@ 25 <> if 4 bit or then 
cpu -> f c@ 245 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 245 h.2 [char] ] emit space then 
cpu -> h c@ 35 <> if 6 bit or then 
cpu -> l c@ 138 <> if 7 bit or then 
cpu -> i_ c@ 125 <> if 8 bit or then 
cpu -> r c@ 38 <> if 9 bit or then 
cpu -> a_ c@ 243 <> cpu -> f_ c@ 159 <> or if 10 bit or then 
cpu -> b_ c@ 39 <> cpu -> c_ c@ 123 <> or if 11 bit or then 
cpu -> d_ c@ 213 <> cpu -> e_ c@ 73 <> or if 12 bit or then 
cpu -> h_ c@ 78 <> cpu -> l_ c@ 35 <> or if 13 bit or then 
cpu -> ix h@ 5220 <> if 14 bit or then 
cpu -> iy h@ 23753 <> if 15 bit or then 
cpu -> pc h@ 47946 <> if 16 bit or then 
cpu -> sp h@ 10948 <> if 17 bit or then 
cpu -> mem_ptr h@ 5228 <> if 18 bit or then 
5228 ram + c@ 164 <> if 19 bit or then 
47943 ram + c@ 221 <> if 19 bit or then 
47944 ram + c@ 70 <> if 19 bit or then 
47945 ram + c@ 8 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 47 0000 : " 
35441 cpu -> pc h! 58658 cpu -> sp h! 
171 cpu -> a c! 155 cpu -> b c! 238 cpu -> c c! 52 cpu -> d c! 
133 cpu -> e c! 213 cpu -> f c! 101 cpu -> h c! 139 cpu -> l c! 
78 cpu -> i_ c! 105 cpu -> r c! 35109 cpu -> mem_ptr h! 
9346 cpu -> ix h! 42425 cpu -> iy h! 
226 cpu -> a_ c! 25 cpu -> f_ c! 252 cpu -> b_ c! 67 cpu -> c_ c! 
217 cpu -> d_ c! 176 cpu -> e_ c! 254 cpu -> h_ c! 124 cpu -> l_ c! 
221 ram 35441 + c! 71 ram 35442 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 171 <> if 0 bit or then 
cpu -> b c@ 171 <> if 1 bit or then 
cpu -> c c@ 238 <> if 2 bit or then 
cpu -> d c@ 52 <> if 3 bit or then 
cpu -> e c@ 133 <> if 4 bit or then 
cpu -> f c@ 213 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 213 h.2 [char] ] emit space then 
cpu -> h c@ 101 <> if 6 bit or then 
cpu -> l c@ 139 <> if 7 bit or then 
cpu -> i_ c@ 78 <> if 8 bit or then 
cpu -> r c@ 107 <> if 9 bit or then 
cpu -> a_ c@ 226 <> cpu -> f_ c@ 25 <> or if 10 bit or then 
cpu -> b_ c@ 252 <> cpu -> c_ c@ 67 <> or if 11 bit or then 
cpu -> d_ c@ 217 <> cpu -> e_ c@ 176 <> or if 12 bit or then 
cpu -> h_ c@ 254 <> cpu -> l_ c@ 124 <> or if 13 bit or then 
cpu -> ix h@ 9346 <> if 14 bit or then 
cpu -> iy h@ 42425 <> if 15 bit or then 
cpu -> pc h@ 35443 <> if 16 bit or then 
cpu -> sp h@ 58658 <> if 17 bit or then 
cpu -> mem_ptr h@ 35109 <> if 18 bit or then 
35441 ram + c@ 221 <> if 19 bit or then 
35442 ram + c@ 71 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 47 0001 : " 
25150 cpu -> pc h! 16580 cpu -> sp h! 
95 cpu -> a c! 104 cpu -> b c! 219 cpu -> c c! 148 cpu -> d c! 
63 cpu -> e c! 28 cpu -> f c! 146 cpu -> h c! 186 cpu -> l c! 
119 cpu -> i_ c! 103 cpu -> r c! 61975 cpu -> mem_ptr h! 
38922 cpu -> ix h! 56546 cpu -> iy h! 
242 cpu -> a_ c! 78 cpu -> f_ c! 111 cpu -> b_ c! 158 cpu -> c_ c! 
163 cpu -> d_ c! 4 cpu -> e_ c! 62 cpu -> h_ c! 33 cpu -> l_ c! 
221 ram 25150 + c! 71 ram 25151 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 95 <> if 0 bit or then 
cpu -> b c@ 95 <> if 1 bit or then 
cpu -> c c@ 219 <> if 2 bit or then 
cpu -> d c@ 148 <> if 3 bit or then 
cpu -> e c@ 63 <> if 4 bit or then 
cpu -> f c@ 28 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 28 h.2 [char] ] emit space then 
cpu -> h c@ 146 <> if 6 bit or then 
cpu -> l c@ 186 <> if 7 bit or then 
cpu -> i_ c@ 119 <> if 8 bit or then 
cpu -> r c@ 105 <> if 9 bit or then 
cpu -> a_ c@ 242 <> cpu -> f_ c@ 78 <> or if 10 bit or then 
cpu -> b_ c@ 111 <> cpu -> c_ c@ 158 <> or if 11 bit or then 
cpu -> d_ c@ 163 <> cpu -> e_ c@ 4 <> or if 12 bit or then 
cpu -> h_ c@ 62 <> cpu -> l_ c@ 33 <> or if 13 bit or then 
cpu -> ix h@ 38922 <> if 14 bit or then 
cpu -> iy h@ 56546 <> if 15 bit or then 
cpu -> pc h@ 25152 <> if 16 bit or then 
cpu -> sp h@ 16580 <> if 17 bit or then 
cpu -> mem_ptr h@ 61975 <> if 18 bit or then 
25150 ram + c@ 221 <> if 19 bit or then 
25151 ram + c@ 71 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 47 0002 : " 
31856 cpu -> pc h! 34771 cpu -> sp h! 
173 cpu -> a c! 245 cpu -> b c! 91 cpu -> c c! 131 cpu -> d c! 
196 cpu -> e c! 89 cpu -> f c! 123 cpu -> h c! 14 cpu -> l c! 
229 cpu -> i_ c! 8 cpu -> r c! 14103 cpu -> mem_ptr h! 
10973 cpu -> ix h! 19737 cpu -> iy h! 
241 cpu -> a_ c! 168 cpu -> f_ c! 103 cpu -> b_ c! 208 cpu -> c_ c! 
153 cpu -> d_ c! 113 cpu -> e_ c! 60 cpu -> h_ c! 83 cpu -> l_ c! 
221 ram 31856 + c! 71 ram 31857 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 173 <> if 0 bit or then 
cpu -> b c@ 173 <> if 1 bit or then 
cpu -> c c@ 91 <> if 2 bit or then 
cpu -> d c@ 131 <> if 3 bit or then 
cpu -> e c@ 196 <> if 4 bit or then 
cpu -> f c@ 89 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 89 h.2 [char] ] emit space then 
cpu -> h c@ 123 <> if 6 bit or then 
cpu -> l c@ 14 <> if 7 bit or then 
cpu -> i_ c@ 229 <> if 8 bit or then 
cpu -> r c@ 10 <> if 9 bit or then 
cpu -> a_ c@ 241 <> cpu -> f_ c@ 168 <> or if 10 bit or then 
cpu -> b_ c@ 103 <> cpu -> c_ c@ 208 <> or if 11 bit or then 
cpu -> d_ c@ 153 <> cpu -> e_ c@ 113 <> or if 12 bit or then 
cpu -> h_ c@ 60 <> cpu -> l_ c@ 83 <> or if 13 bit or then 
cpu -> ix h@ 10973 <> if 14 bit or then 
cpu -> iy h@ 19737 <> if 15 bit or then 
cpu -> pc h@ 31858 <> if 16 bit or then 
cpu -> sp h@ 34771 <> if 17 bit or then 
cpu -> mem_ptr h@ 14103 <> if 18 bit or then 
31856 ram + c@ 221 <> if 19 bit or then 
31857 ram + c@ 71 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 47 0003 : " 
18960 cpu -> pc h! 11061 cpu -> sp h! 
185 cpu -> a c! 3 cpu -> b c! 79 cpu -> c c! 12 cpu -> d c! 
111 cpu -> e c! 11 cpu -> f c! 251 cpu -> h c! 182 cpu -> l c! 
83 cpu -> i_ c! 117 cpu -> r c! 64781 cpu -> mem_ptr h! 
32463 cpu -> ix h! 14165 cpu -> iy h! 
168 cpu -> a_ c! 189 cpu -> f_ c! 99 cpu -> b_ c! 64 cpu -> c_ c! 
182 cpu -> d_ c! 232 cpu -> e_ c! 118 cpu -> h_ c! 235 cpu -> l_ c! 
221 ram 18960 + c! 71 ram 18961 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 185 <> if 0 bit or then 
cpu -> b c@ 185 <> if 1 bit or then 
cpu -> c c@ 79 <> if 2 bit or then 
cpu -> d c@ 12 <> if 3 bit or then 
cpu -> e c@ 111 <> if 4 bit or then 
cpu -> f c@ 11 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 11 h.2 [char] ] emit space then 
cpu -> h c@ 251 <> if 6 bit or then 
cpu -> l c@ 182 <> if 7 bit or then 
cpu -> i_ c@ 83 <> if 8 bit or then 
cpu -> r c@ 119 <> if 9 bit or then 
cpu -> a_ c@ 168 <> cpu -> f_ c@ 189 <> or if 10 bit or then 
cpu -> b_ c@ 99 <> cpu -> c_ c@ 64 <> or if 11 bit or then 
cpu -> d_ c@ 182 <> cpu -> e_ c@ 232 <> or if 12 bit or then 
cpu -> h_ c@ 118 <> cpu -> l_ c@ 235 <> or if 13 bit or then 
cpu -> ix h@ 32463 <> if 14 bit or then 
cpu -> iy h@ 14165 <> if 15 bit or then 
cpu -> pc h@ 18962 <> if 16 bit or then 
cpu -> sp h@ 11061 <> if 17 bit or then 
cpu -> mem_ptr h@ 64781 <> if 18 bit or then 
18960 ram + c@ 221 <> if 19 bit or then 
18961 ram + c@ 71 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 47 0004 : " 
60043 cpu -> pc h! 51868 cpu -> sp h! 
13 cpu -> a c! 15 cpu -> b c! 184 cpu -> c c! 126 cpu -> d c! 
38 cpu -> e c! 103 cpu -> f c! 214 cpu -> h c! 105 cpu -> l c! 
49 cpu -> i_ c! 55 cpu -> r c! 44696 cpu -> mem_ptr h! 
43486 cpu -> ix h! 5111 cpu -> iy h! 
228 cpu -> a_ c! 103 cpu -> f_ c! 123 cpu -> b_ c! 87 cpu -> c_ c! 
120 cpu -> d_ c! 71 cpu -> e_ c! 226 cpu -> h_ c! 238 cpu -> l_ c! 
221 ram 60043 + c! 71 ram 60044 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 13 <> if 0 bit or then 
cpu -> b c@ 13 <> if 1 bit or then 
cpu -> c c@ 184 <> if 2 bit or then 
cpu -> d c@ 126 <> if 3 bit or then 
cpu -> e c@ 38 <> if 4 bit or then 
cpu -> f c@ 103 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 103 h.2 [char] ] emit space then 
cpu -> h c@ 214 <> if 6 bit or then 
cpu -> l c@ 105 <> if 7 bit or then 
cpu -> i_ c@ 49 <> if 8 bit or then 
cpu -> r c@ 57 <> if 9 bit or then 
cpu -> a_ c@ 228 <> cpu -> f_ c@ 103 <> or if 10 bit or then 
cpu -> b_ c@ 123 <> cpu -> c_ c@ 87 <> or if 11 bit or then 
cpu -> d_ c@ 120 <> cpu -> e_ c@ 71 <> or if 12 bit or then 
cpu -> h_ c@ 226 <> cpu -> l_ c@ 238 <> or if 13 bit or then 
cpu -> ix h@ 43486 <> if 14 bit or then 
cpu -> iy h@ 5111 <> if 15 bit or then 
cpu -> pc h@ 60045 <> if 16 bit or then 
cpu -> sp h@ 51868 <> if 17 bit or then 
cpu -> mem_ptr h@ 44696 <> if 18 bit or then 
60043 ram + c@ 221 <> if 19 bit or then 
60044 ram + c@ 71 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 48 0000 : " 
58077 cpu -> pc h! 53936 cpu -> sp h! 
112 cpu -> a c! 135 cpu -> b c! 9 cpu -> c c! 203 cpu -> d c! 
247 cpu -> e c! 113 cpu -> f c! 206 cpu -> h c! 91 cpu -> l c! 
207 cpu -> i_ c! 20 cpu -> r c! 46307 cpu -> mem_ptr h! 
24587 cpu -> ix h! 50285 cpu -> iy h! 
96 cpu -> a_ c! 15 cpu -> f_ c! 107 cpu -> b_ c! 89 cpu -> c_ c! 
142 cpu -> d_ c! 224 cpu -> e_ c! 28 cpu -> h_ c! 128 cpu -> l_ c! 
221 ram 58077 + c! 72 ram 58078 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 112 <> if 0 bit or then 
cpu -> b c@ 135 <> if 1 bit or then 
cpu -> c c@ 135 <> if 2 bit or then 
cpu -> d c@ 203 <> if 3 bit or then 
cpu -> e c@ 247 <> if 4 bit or then 
cpu -> f c@ 113 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 113 h.2 [char] ] emit space then 
cpu -> h c@ 206 <> if 6 bit or then 
cpu -> l c@ 91 <> if 7 bit or then 
cpu -> i_ c@ 207 <> if 8 bit or then 
cpu -> r c@ 22 <> if 9 bit or then 
cpu -> a_ c@ 96 <> cpu -> f_ c@ 15 <> or if 10 bit or then 
cpu -> b_ c@ 107 <> cpu -> c_ c@ 89 <> or if 11 bit or then 
cpu -> d_ c@ 142 <> cpu -> e_ c@ 224 <> or if 12 bit or then 
cpu -> h_ c@ 28 <> cpu -> l_ c@ 128 <> or if 13 bit or then 
cpu -> ix h@ 24587 <> if 14 bit or then 
cpu -> iy h@ 50285 <> if 15 bit or then 
cpu -> pc h@ 58079 <> if 16 bit or then 
cpu -> sp h@ 53936 <> if 17 bit or then 
cpu -> mem_ptr h@ 46307 <> if 18 bit or then 
58077 ram + c@ 221 <> if 19 bit or then 
58078 ram + c@ 72 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 48 0001 : " 
47755 cpu -> pc h! 58973 cpu -> sp h! 
83 cpu -> a c! 203 cpu -> b c! 51 cpu -> c c! 48 cpu -> d c! 
100 cpu -> e c! 168 cpu -> f c! 94 cpu -> h c! 50 cpu -> l c! 
108 cpu -> i_ c! 46 cpu -> r c! 8134 cpu -> mem_ptr h! 
62921 cpu -> ix h! 11527 cpu -> iy h! 
5 cpu -> a_ c! 66 cpu -> f_ c! 116 cpu -> b_ c! 200 cpu -> c_ c! 
60 cpu -> d_ c! 77 cpu -> e_ c! 34 cpu -> h_ c! 35 cpu -> l_ c! 
221 ram 47755 + c! 72 ram 47756 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 83 <> if 0 bit or then 
cpu -> b c@ 203 <> if 1 bit or then 
cpu -> c c@ 203 <> if 2 bit or then 
cpu -> d c@ 48 <> if 3 bit or then 
cpu -> e c@ 100 <> if 4 bit or then 
cpu -> f c@ 168 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 168 h.2 [char] ] emit space then 
cpu -> h c@ 94 <> if 6 bit or then 
cpu -> l c@ 50 <> if 7 bit or then 
cpu -> i_ c@ 108 <> if 8 bit or then 
cpu -> r c@ 48 <> if 9 bit or then 
cpu -> a_ c@ 5 <> cpu -> f_ c@ 66 <> or if 10 bit or then 
cpu -> b_ c@ 116 <> cpu -> c_ c@ 200 <> or if 11 bit or then 
cpu -> d_ c@ 60 <> cpu -> e_ c@ 77 <> or if 12 bit or then 
cpu -> h_ c@ 34 <> cpu -> l_ c@ 35 <> or if 13 bit or then 
cpu -> ix h@ 62921 <> if 14 bit or then 
cpu -> iy h@ 11527 <> if 15 bit or then 
cpu -> pc h@ 47757 <> if 16 bit or then 
cpu -> sp h@ 58973 <> if 17 bit or then 
cpu -> mem_ptr h@ 8134 <> if 18 bit or then 
47755 ram + c@ 221 <> if 19 bit or then 
47756 ram + c@ 72 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 48 0002 : " 
28038 cpu -> pc h! 51843 cpu -> sp h! 
15 cpu -> a c! 160 cpu -> b c! 248 cpu -> c c! 242 cpu -> d c! 
155 cpu -> e c! 126 cpu -> f c! 53 cpu -> h c! 181 cpu -> l c! 
149 cpu -> i_ c! 2 cpu -> r c! 32699 cpu -> mem_ptr h! 
61182 cpu -> ix h! 31069 cpu -> iy h! 
8 cpu -> a_ c! 60 cpu -> f_ c! 152 cpu -> b_ c! 19 cpu -> c_ c! 
245 cpu -> d_ c! 101 cpu -> e_ c! 36 cpu -> h_ c! 212 cpu -> l_ c! 
221 ram 28038 + c! 72 ram 28039 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 15 <> if 0 bit or then 
cpu -> b c@ 160 <> if 1 bit or then 
cpu -> c c@ 160 <> if 2 bit or then 
cpu -> d c@ 242 <> if 3 bit or then 
cpu -> e c@ 155 <> if 4 bit or then 
cpu -> f c@ 126 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 126 h.2 [char] ] emit space then 
cpu -> h c@ 53 <> if 6 bit or then 
cpu -> l c@ 181 <> if 7 bit or then 
cpu -> i_ c@ 149 <> if 8 bit or then 
cpu -> r c@ 4 <> if 9 bit or then 
cpu -> a_ c@ 8 <> cpu -> f_ c@ 60 <> or if 10 bit or then 
cpu -> b_ c@ 152 <> cpu -> c_ c@ 19 <> or if 11 bit or then 
cpu -> d_ c@ 245 <> cpu -> e_ c@ 101 <> or if 12 bit or then 
cpu -> h_ c@ 36 <> cpu -> l_ c@ 212 <> or if 13 bit or then 
cpu -> ix h@ 61182 <> if 14 bit or then 
cpu -> iy h@ 31069 <> if 15 bit or then 
cpu -> pc h@ 28040 <> if 16 bit or then 
cpu -> sp h@ 51843 <> if 17 bit or then 
cpu -> mem_ptr h@ 32699 <> if 18 bit or then 
28038 ram + c@ 221 <> if 19 bit or then 
28039 ram + c@ 72 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 48 0003 : " 
57340 cpu -> pc h! 21881 cpu -> sp h! 
227 cpu -> a c! 250 cpu -> b c! 118 cpu -> c c! 145 cpu -> d c! 
32 cpu -> e c! 82 cpu -> f c! 226 cpu -> h c! 13 cpu -> l c! 
19 cpu -> i_ c! 123 cpu -> r c! 54052 cpu -> mem_ptr h! 
41316 cpu -> ix h! 38394 cpu -> iy h! 
226 cpu -> a_ c! 36 cpu -> f_ c! 37 cpu -> b_ c! 27 cpu -> c_ c! 
113 cpu -> d_ c! 194 cpu -> e_ c! 62 cpu -> h_ c! 185 cpu -> l_ c! 
221 ram 57340 + c! 72 ram 57341 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 227 <> if 0 bit or then 
cpu -> b c@ 250 <> if 1 bit or then 
cpu -> c c@ 250 <> if 2 bit or then 
cpu -> d c@ 145 <> if 3 bit or then 
cpu -> e c@ 32 <> if 4 bit or then 
cpu -> f c@ 82 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 82 h.2 [char] ] emit space then 
cpu -> h c@ 226 <> if 6 bit or then 
cpu -> l c@ 13 <> if 7 bit or then 
cpu -> i_ c@ 19 <> if 8 bit or then 
cpu -> r c@ 125 <> if 9 bit or then 
cpu -> a_ c@ 226 <> cpu -> f_ c@ 36 <> or if 10 bit or then 
cpu -> b_ c@ 37 <> cpu -> c_ c@ 27 <> or if 11 bit or then 
cpu -> d_ c@ 113 <> cpu -> e_ c@ 194 <> or if 12 bit or then 
cpu -> h_ c@ 62 <> cpu -> l_ c@ 185 <> or if 13 bit or then 
cpu -> ix h@ 41316 <> if 14 bit or then 
cpu -> iy h@ 38394 <> if 15 bit or then 
cpu -> pc h@ 57342 <> if 16 bit or then 
cpu -> sp h@ 21881 <> if 17 bit or then 
cpu -> mem_ptr h@ 54052 <> if 18 bit or then 
57340 ram + c@ 221 <> if 19 bit or then 
57341 ram + c@ 72 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 48 0004 : " 
41357 cpu -> pc h! 34526 cpu -> sp h! 
202 cpu -> a c! 151 cpu -> b c! 227 cpu -> c c! 17 cpu -> d c! 
247 cpu -> e c! 237 cpu -> f c! 78 cpu -> h c! 60 cpu -> l c! 
212 cpu -> i_ c! 19 cpu -> r c! 50937 cpu -> mem_ptr h! 
46878 cpu -> ix h! 65264 cpu -> iy h! 
189 cpu -> a_ c! 108 cpu -> f_ c! 145 cpu -> b_ c! 203 cpu -> c_ c! 
121 cpu -> d_ c! 189 cpu -> e_ c! 2 cpu -> h_ c! 194 cpu -> l_ c! 
221 ram 41357 + c! 72 ram 41358 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 202 <> if 0 bit or then 
cpu -> b c@ 151 <> if 1 bit or then 
cpu -> c c@ 151 <> if 2 bit or then 
cpu -> d c@ 17 <> if 3 bit or then 
cpu -> e c@ 247 <> if 4 bit or then 
cpu -> f c@ 237 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 237 h.2 [char] ] emit space then 
cpu -> h c@ 78 <> if 6 bit or then 
cpu -> l c@ 60 <> if 7 bit or then 
cpu -> i_ c@ 212 <> if 8 bit or then 
cpu -> r c@ 21 <> if 9 bit or then 
cpu -> a_ c@ 189 <> cpu -> f_ c@ 108 <> or if 10 bit or then 
cpu -> b_ c@ 145 <> cpu -> c_ c@ 203 <> or if 11 bit or then 
cpu -> d_ c@ 121 <> cpu -> e_ c@ 189 <> or if 12 bit or then 
cpu -> h_ c@ 2 <> cpu -> l_ c@ 194 <> or if 13 bit or then 
cpu -> ix h@ 46878 <> if 14 bit or then 
cpu -> iy h@ 65264 <> if 15 bit or then 
cpu -> pc h@ 41359 <> if 16 bit or then 
cpu -> sp h@ 34526 <> if 17 bit or then 
cpu -> mem_ptr h@ 50937 <> if 18 bit or then 
41357 ram + c@ 221 <> if 19 bit or then 
41358 ram + c@ 72 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 49 0000 : " 
32599 cpu -> pc h! 32858 cpu -> sp h! 
93 cpu -> a c! 151 cpu -> b c! 142 cpu -> c c! 3 cpu -> d c! 
76 cpu -> e c! 236 cpu -> f c! 220 cpu -> h c! 79 cpu -> l c! 
206 cpu -> i_ c! 39 cpu -> r c! 58874 cpu -> mem_ptr h! 
56261 cpu -> ix h! 56390 cpu -> iy h! 
147 cpu -> a_ c! 144 cpu -> f_ c! 25 cpu -> b_ c! 157 cpu -> c_ c! 
187 cpu -> d_ c! 71 cpu -> e_ c! 96 cpu -> h_ c! 252 cpu -> l_ c! 
221 ram 32599 + c! 73 ram 32600 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 93 <> if 0 bit or then 
cpu -> b c@ 151 <> if 1 bit or then 
cpu -> c c@ 142 <> if 2 bit or then 
cpu -> d c@ 3 <> if 3 bit or then 
cpu -> e c@ 76 <> if 4 bit or then 
cpu -> f c@ 236 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 236 h.2 [char] ] emit space then 
cpu -> h c@ 220 <> if 6 bit or then 
cpu -> l c@ 79 <> if 7 bit or then 
cpu -> i_ c@ 206 <> if 8 bit or then 
cpu -> r c@ 41 <> if 9 bit or then 
cpu -> a_ c@ 147 <> cpu -> f_ c@ 144 <> or if 10 bit or then 
cpu -> b_ c@ 25 <> cpu -> c_ c@ 157 <> or if 11 bit or then 
cpu -> d_ c@ 187 <> cpu -> e_ c@ 71 <> or if 12 bit or then 
cpu -> h_ c@ 96 <> cpu -> l_ c@ 252 <> or if 13 bit or then 
cpu -> ix h@ 56261 <> if 14 bit or then 
cpu -> iy h@ 56390 <> if 15 bit or then 
cpu -> pc h@ 32601 <> if 16 bit or then 
cpu -> sp h@ 32858 <> if 17 bit or then 
cpu -> mem_ptr h@ 58874 <> if 18 bit or then 
32599 ram + c@ 221 <> if 19 bit or then 
32600 ram + c@ 73 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 49 0001 : " 
34025 cpu -> pc h! 15562 cpu -> sp h! 
26 cpu -> a c! 113 cpu -> b c! 156 cpu -> c c! 106 cpu -> d c! 
82 cpu -> e c! 138 cpu -> f c! 1 cpu -> h c! 124 cpu -> l c! 
220 cpu -> i_ c! 39 cpu -> r c! 53475 cpu -> mem_ptr h! 
63084 cpu -> ix h! 53306 cpu -> iy h! 
220 cpu -> a_ c! 39 cpu -> f_ c! 165 cpu -> b_ c! 251 cpu -> c_ c! 
102 cpu -> d_ c! 198 cpu -> e_ c! 169 cpu -> h_ c! 176 cpu -> l_ c! 
221 ram 34025 + c! 73 ram 34026 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 26 <> if 0 bit or then 
cpu -> b c@ 113 <> if 1 bit or then 
cpu -> c c@ 156 <> if 2 bit or then 
cpu -> d c@ 106 <> if 3 bit or then 
cpu -> e c@ 82 <> if 4 bit or then 
cpu -> f c@ 138 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 138 h.2 [char] ] emit space then 
cpu -> h c@ 1 <> if 6 bit or then 
cpu -> l c@ 124 <> if 7 bit or then 
cpu -> i_ c@ 220 <> if 8 bit or then 
cpu -> r c@ 41 <> if 9 bit or then 
cpu -> a_ c@ 220 <> cpu -> f_ c@ 39 <> or if 10 bit or then 
cpu -> b_ c@ 165 <> cpu -> c_ c@ 251 <> or if 11 bit or then 
cpu -> d_ c@ 102 <> cpu -> e_ c@ 198 <> or if 12 bit or then 
cpu -> h_ c@ 169 <> cpu -> l_ c@ 176 <> or if 13 bit or then 
cpu -> ix h@ 63084 <> if 14 bit or then 
cpu -> iy h@ 53306 <> if 15 bit or then 
cpu -> pc h@ 34027 <> if 16 bit or then 
cpu -> sp h@ 15562 <> if 17 bit or then 
cpu -> mem_ptr h@ 53475 <> if 18 bit or then 
34025 ram + c@ 221 <> if 19 bit or then 
34026 ram + c@ 73 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 49 0002 : " 
33296 cpu -> pc h! 54770 cpu -> sp h! 
161 cpu -> a c! 99 cpu -> b c! 189 cpu -> c c! 189 cpu -> d c! 
148 cpu -> e c! 168 cpu -> f c! 74 cpu -> h c! 217 cpu -> l c! 
245 cpu -> i_ c! 124 cpu -> r c! 18938 cpu -> mem_ptr h! 
63192 cpu -> ix h! 38106 cpu -> iy h! 
245 cpu -> a_ c! 109 cpu -> f_ c! 139 cpu -> b_ c! 193 cpu -> c_ c! 
173 cpu -> d_ c! 253 cpu -> e_ c! 133 cpu -> h_ c! 170 cpu -> l_ c! 
221 ram 33296 + c! 73 ram 33297 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 161 <> if 0 bit or then 
cpu -> b c@ 99 <> if 1 bit or then 
cpu -> c c@ 189 <> if 2 bit or then 
cpu -> d c@ 189 <> if 3 bit or then 
cpu -> e c@ 148 <> if 4 bit or then 
cpu -> f c@ 168 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 168 h.2 [char] ] emit space then 
cpu -> h c@ 74 <> if 6 bit or then 
cpu -> l c@ 217 <> if 7 bit or then 
cpu -> i_ c@ 245 <> if 8 bit or then 
cpu -> r c@ 126 <> if 9 bit or then 
cpu -> a_ c@ 245 <> cpu -> f_ c@ 109 <> or if 10 bit or then 
cpu -> b_ c@ 139 <> cpu -> c_ c@ 193 <> or if 11 bit or then 
cpu -> d_ c@ 173 <> cpu -> e_ c@ 253 <> or if 12 bit or then 
cpu -> h_ c@ 133 <> cpu -> l_ c@ 170 <> or if 13 bit or then 
cpu -> ix h@ 63192 <> if 14 bit or then 
cpu -> iy h@ 38106 <> if 15 bit or then 
cpu -> pc h@ 33298 <> if 16 bit or then 
cpu -> sp h@ 54770 <> if 17 bit or then 
cpu -> mem_ptr h@ 18938 <> if 18 bit or then 
33296 ram + c@ 221 <> if 19 bit or then 
33297 ram + c@ 73 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 49 0003 : " 
6442 cpu -> pc h! 4590 cpu -> sp h! 
7 cpu -> a c! 38 cpu -> b c! 117 cpu -> c c! 9 cpu -> d c! 
97 cpu -> e c! 1 cpu -> f c! 124 cpu -> h c! 112 cpu -> l c! 
3 cpu -> i_ c! 85 cpu -> r c! 52702 cpu -> mem_ptr h! 
5763 cpu -> ix h! 60163 cpu -> iy h! 
111 cpu -> a_ c! 3 cpu -> f_ c! 205 cpu -> b_ c! 167 cpu -> c_ c! 
252 cpu -> d_ c! 180 cpu -> e_ c! 31 cpu -> h_ c! 48 cpu -> l_ c! 
221 ram 6442 + c! 73 ram 6443 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 7 <> if 0 bit or then 
cpu -> b c@ 38 <> if 1 bit or then 
cpu -> c c@ 117 <> if 2 bit or then 
cpu -> d c@ 9 <> if 3 bit or then 
cpu -> e c@ 97 <> if 4 bit or then 
cpu -> f c@ 1 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 1 h.2 [char] ] emit space then 
cpu -> h c@ 124 <> if 6 bit or then 
cpu -> l c@ 112 <> if 7 bit or then 
cpu -> i_ c@ 3 <> if 8 bit or then 
cpu -> r c@ 87 <> if 9 bit or then 
cpu -> a_ c@ 111 <> cpu -> f_ c@ 3 <> or if 10 bit or then 
cpu -> b_ c@ 205 <> cpu -> c_ c@ 167 <> or if 11 bit or then 
cpu -> d_ c@ 252 <> cpu -> e_ c@ 180 <> or if 12 bit or then 
cpu -> h_ c@ 31 <> cpu -> l_ c@ 48 <> or if 13 bit or then 
cpu -> ix h@ 5763 <> if 14 bit or then 
cpu -> iy h@ 60163 <> if 15 bit or then 
cpu -> pc h@ 6444 <> if 16 bit or then 
cpu -> sp h@ 4590 <> if 17 bit or then 
cpu -> mem_ptr h@ 52702 <> if 18 bit or then 
6442 ram + c@ 221 <> if 19 bit or then 
6443 ram + c@ 73 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 49 0004 : " 
31402 cpu -> pc h! 32819 cpu -> sp h! 
162 cpu -> a c! 86 cpu -> b c! 79 cpu -> c c! 9 cpu -> d c! 
42 cpu -> e c! 118 cpu -> f c! 68 cpu -> h c! 95 cpu -> l c! 
48 cpu -> i_ c! 100 cpu -> r c! 18554 cpu -> mem_ptr h! 
23690 cpu -> ix h! 39630 cpu -> iy h! 
200 cpu -> a_ c! 49 cpu -> f_ c! 28 cpu -> b_ c! 86 cpu -> c_ c! 
189 cpu -> d_ c! 132 cpu -> e_ c! 252 cpu -> h_ c! 214 cpu -> l_ c! 
221 ram 31402 + c! 73 ram 31403 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 162 <> if 0 bit or then 
cpu -> b c@ 86 <> if 1 bit or then 
cpu -> c c@ 79 <> if 2 bit or then 
cpu -> d c@ 9 <> if 3 bit or then 
cpu -> e c@ 42 <> if 4 bit or then 
cpu -> f c@ 118 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 118 h.2 [char] ] emit space then 
cpu -> h c@ 68 <> if 6 bit or then 
cpu -> l c@ 95 <> if 7 bit or then 
cpu -> i_ c@ 48 <> if 8 bit or then 
cpu -> r c@ 102 <> if 9 bit or then 
cpu -> a_ c@ 200 <> cpu -> f_ c@ 49 <> or if 10 bit or then 
cpu -> b_ c@ 28 <> cpu -> c_ c@ 86 <> or if 11 bit or then 
cpu -> d_ c@ 189 <> cpu -> e_ c@ 132 <> or if 12 bit or then 
cpu -> h_ c@ 252 <> cpu -> l_ c@ 214 <> or if 13 bit or then 
cpu -> ix h@ 23690 <> if 14 bit or then 
cpu -> iy h@ 39630 <> if 15 bit or then 
cpu -> pc h@ 31404 <> if 16 bit or then 
cpu -> sp h@ 32819 <> if 17 bit or then 
cpu -> mem_ptr h@ 18554 <> if 18 bit or then 
31402 ram + c@ 221 <> if 19 bit or then 
31403 ram + c@ 73 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4A 0000 : " 
45980 cpu -> pc h! 8604 cpu -> sp h! 
254 cpu -> a c! 190 cpu -> b c! 201 cpu -> c c! 157 cpu -> d c! 
69 cpu -> e c! 45 cpu -> f c! 180 cpu -> h c! 181 cpu -> l c! 
134 cpu -> i_ c! 42 cpu -> r c! 63911 cpu -> mem_ptr h! 
19519 cpu -> ix h! 60236 cpu -> iy h! 
174 cpu -> a_ c! 180 cpu -> f_ c! 71 cpu -> b_ c! 181 cpu -> c_ c! 
3 cpu -> d_ c! 123 cpu -> e_ c! 82 cpu -> h_ c! 167 cpu -> l_ c! 
221 ram 45980 + c! 74 ram 45981 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 254 <> if 0 bit or then 
cpu -> b c@ 190 <> if 1 bit or then 
cpu -> c c@ 157 <> if 2 bit or then 
cpu -> d c@ 157 <> if 3 bit or then 
cpu -> e c@ 69 <> if 4 bit or then 
cpu -> f c@ 45 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 45 h.2 [char] ] emit space then 
cpu -> h c@ 180 <> if 6 bit or then 
cpu -> l c@ 181 <> if 7 bit or then 
cpu -> i_ c@ 134 <> if 8 bit or then 
cpu -> r c@ 44 <> if 9 bit or then 
cpu -> a_ c@ 174 <> cpu -> f_ c@ 180 <> or if 10 bit or then 
cpu -> b_ c@ 71 <> cpu -> c_ c@ 181 <> or if 11 bit or then 
cpu -> d_ c@ 3 <> cpu -> e_ c@ 123 <> or if 12 bit or then 
cpu -> h_ c@ 82 <> cpu -> l_ c@ 167 <> or if 13 bit or then 
cpu -> ix h@ 19519 <> if 14 bit or then 
cpu -> iy h@ 60236 <> if 15 bit or then 
cpu -> pc h@ 45982 <> if 16 bit or then 
cpu -> sp h@ 8604 <> if 17 bit or then 
cpu -> mem_ptr h@ 63911 <> if 18 bit or then 
45980 ram + c@ 221 <> if 19 bit or then 
45981 ram + c@ 74 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4A 0001 : " 
42707 cpu -> pc h! 745 cpu -> sp h! 
240 cpu -> a c! 45 cpu -> b c! 102 cpu -> c c! 241 cpu -> d c! 
0 cpu -> e c! 96 cpu -> f c! 183 cpu -> h c! 166 cpu -> l c! 
90 cpu -> i_ c! 22 cpu -> r c! 1679 cpu -> mem_ptr h! 
23264 cpu -> ix h! 61364 cpu -> iy h! 
134 cpu -> a_ c! 176 cpu -> f_ c! 78 cpu -> b_ c! 183 cpu -> c_ c! 
226 cpu -> d_ c! 125 cpu -> e_ c! 224 cpu -> h_ c! 16 cpu -> l_ c! 
221 ram 42707 + c! 74 ram 42708 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 240 <> if 0 bit or then 
cpu -> b c@ 45 <> if 1 bit or then 
cpu -> c c@ 241 <> if 2 bit or then 
cpu -> d c@ 241 <> if 3 bit or then 
cpu -> e c@ 0 <> if 4 bit or then 
cpu -> f c@ 96 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 96 h.2 [char] ] emit space then 
cpu -> h c@ 183 <> if 6 bit or then 
cpu -> l c@ 166 <> if 7 bit or then 
cpu -> i_ c@ 90 <> if 8 bit or then 
cpu -> r c@ 24 <> if 9 bit or then 
cpu -> a_ c@ 134 <> cpu -> f_ c@ 176 <> or if 10 bit or then 
cpu -> b_ c@ 78 <> cpu -> c_ c@ 183 <> or if 11 bit or then 
cpu -> d_ c@ 226 <> cpu -> e_ c@ 125 <> or if 12 bit or then 
cpu -> h_ c@ 224 <> cpu -> l_ c@ 16 <> or if 13 bit or then 
cpu -> ix h@ 23264 <> if 14 bit or then 
cpu -> iy h@ 61364 <> if 15 bit or then 
cpu -> pc h@ 42709 <> if 16 bit or then 
cpu -> sp h@ 745 <> if 17 bit or then 
cpu -> mem_ptr h@ 1679 <> if 18 bit or then 
42707 ram + c@ 221 <> if 19 bit or then 
42708 ram + c@ 74 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4A 0002 : " 
12398 cpu -> pc h! 54861 cpu -> sp h! 
6 cpu -> a c! 156 cpu -> b c! 143 cpu -> c c! 210 cpu -> d c! 
1 cpu -> e c! 7 cpu -> f c! 222 cpu -> h c! 168 cpu -> l c! 
167 cpu -> i_ c! 88 cpu -> r c! 19615 cpu -> mem_ptr h! 
32213 cpu -> ix h! 31020 cpu -> iy h! 
138 cpu -> a_ c! 223 cpu -> f_ c! 71 cpu -> b_ c! 66 cpu -> c_ c! 
179 cpu -> d_ c! 191 cpu -> e_ c! 161 cpu -> h_ c! 27 cpu -> l_ c! 
221 ram 12398 + c! 74 ram 12399 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 6 <> if 0 bit or then 
cpu -> b c@ 156 <> if 1 bit or then 
cpu -> c c@ 210 <> if 2 bit or then 
cpu -> d c@ 210 <> if 3 bit or then 
cpu -> e c@ 1 <> if 4 bit or then 
cpu -> f c@ 7 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 7 h.2 [char] ] emit space then 
cpu -> h c@ 222 <> if 6 bit or then 
cpu -> l c@ 168 <> if 7 bit or then 
cpu -> i_ c@ 167 <> if 8 bit or then 
cpu -> r c@ 90 <> if 9 bit or then 
cpu -> a_ c@ 138 <> cpu -> f_ c@ 223 <> or if 10 bit or then 
cpu -> b_ c@ 71 <> cpu -> c_ c@ 66 <> or if 11 bit or then 
cpu -> d_ c@ 179 <> cpu -> e_ c@ 191 <> or if 12 bit or then 
cpu -> h_ c@ 161 <> cpu -> l_ c@ 27 <> or if 13 bit or then 
cpu -> ix h@ 32213 <> if 14 bit or then 
cpu -> iy h@ 31020 <> if 15 bit or then 
cpu -> pc h@ 12400 <> if 16 bit or then 
cpu -> sp h@ 54861 <> if 17 bit or then 
cpu -> mem_ptr h@ 19615 <> if 18 bit or then 
12398 ram + c@ 221 <> if 19 bit or then 
12399 ram + c@ 74 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4A 0003 : " 
48138 cpu -> pc h! 50268 cpu -> sp h! 
91 cpu -> a c! 237 cpu -> b c! 136 cpu -> c c! 255 cpu -> d c! 
175 cpu -> e c! 94 cpu -> f c! 228 cpu -> h c! 128 cpu -> l c! 
178 cpu -> i_ c! 16 cpu -> r c! 49395 cpu -> mem_ptr h! 
26014 cpu -> ix h! 58498 cpu -> iy h! 
116 cpu -> a_ c! 107 cpu -> f_ c! 15 cpu -> b_ c! 102 cpu -> c_ c! 
187 cpu -> d_ c! 194 cpu -> e_ c! 50 cpu -> h_ c! 50 cpu -> l_ c! 
221 ram 48138 + c! 74 ram 48139 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 91 <> if 0 bit or then 
cpu -> b c@ 237 <> if 1 bit or then 
cpu -> c c@ 255 <> if 2 bit or then 
cpu -> d c@ 255 <> if 3 bit or then 
cpu -> e c@ 175 <> if 4 bit or then 
cpu -> f c@ 94 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 94 h.2 [char] ] emit space then 
cpu -> h c@ 228 <> if 6 bit or then 
cpu -> l c@ 128 <> if 7 bit or then 
cpu -> i_ c@ 178 <> if 8 bit or then 
cpu -> r c@ 18 <> if 9 bit or then 
cpu -> a_ c@ 116 <> cpu -> f_ c@ 107 <> or if 10 bit or then 
cpu -> b_ c@ 15 <> cpu -> c_ c@ 102 <> or if 11 bit or then 
cpu -> d_ c@ 187 <> cpu -> e_ c@ 194 <> or if 12 bit or then 
cpu -> h_ c@ 50 <> cpu -> l_ c@ 50 <> or if 13 bit or then 
cpu -> ix h@ 26014 <> if 14 bit or then 
cpu -> iy h@ 58498 <> if 15 bit or then 
cpu -> pc h@ 48140 <> if 16 bit or then 
cpu -> sp h@ 50268 <> if 17 bit or then 
cpu -> mem_ptr h@ 49395 <> if 18 bit or then 
48138 ram + c@ 221 <> if 19 bit or then 
48139 ram + c@ 74 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4A 0004 : " 
60091 cpu -> pc h! 14012 cpu -> sp h! 
33 cpu -> a c! 140 cpu -> b c! 93 cpu -> c c! 147 cpu -> d c! 
27 cpu -> e c! 248 cpu -> f c! 69 cpu -> h c! 76 cpu -> l c! 
233 cpu -> i_ c! 62 cpu -> r c! 46000 cpu -> mem_ptr h! 
30977 cpu -> ix h! 36606 cpu -> iy h! 
107 cpu -> a_ c! 193 cpu -> f_ c! 159 cpu -> b_ c! 123 cpu -> c_ c! 
5 cpu -> d_ c! 82 cpu -> e_ c! 18 cpu -> h_ c! 106 cpu -> l_ c! 
221 ram 60091 + c! 74 ram 60092 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 33 <> if 0 bit or then 
cpu -> b c@ 140 <> if 1 bit or then 
cpu -> c c@ 147 <> if 2 bit or then 
cpu -> d c@ 147 <> if 3 bit or then 
cpu -> e c@ 27 <> if 4 bit or then 
cpu -> f c@ 248 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 248 h.2 [char] ] emit space then 
cpu -> h c@ 69 <> if 6 bit or then 
cpu -> l c@ 76 <> if 7 bit or then 
cpu -> i_ c@ 233 <> if 8 bit or then 
cpu -> r c@ 64 <> if 9 bit or then 
cpu -> a_ c@ 107 <> cpu -> f_ c@ 193 <> or if 10 bit or then 
cpu -> b_ c@ 159 <> cpu -> c_ c@ 123 <> or if 11 bit or then 
cpu -> d_ c@ 5 <> cpu -> e_ c@ 82 <> or if 12 bit or then 
cpu -> h_ c@ 18 <> cpu -> l_ c@ 106 <> or if 13 bit or then 
cpu -> ix h@ 30977 <> if 14 bit or then 
cpu -> iy h@ 36606 <> if 15 bit or then 
cpu -> pc h@ 60093 <> if 16 bit or then 
cpu -> sp h@ 14012 <> if 17 bit or then 
cpu -> mem_ptr h@ 46000 <> if 18 bit or then 
60091 ram + c@ 221 <> if 19 bit or then 
60092 ram + c@ 74 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4B 0000 : " 
49046 cpu -> pc h! 7233 cpu -> sp h! 
245 cpu -> a c! 161 cpu -> b c! 194 cpu -> c c! 26 cpu -> d c! 
16 cpu -> e c! 110 cpu -> f c! 86 cpu -> h c! 172 cpu -> l c! 
172 cpu -> i_ c! 59 cpu -> r c! 44383 cpu -> mem_ptr h! 
59073 cpu -> ix h! 39341 cpu -> iy h! 
95 cpu -> a_ c! 183 cpu -> f_ c! 182 cpu -> b_ c! 23 cpu -> c_ c! 
237 cpu -> d_ c! 182 cpu -> e_ c! 117 cpu -> h_ c! 15 cpu -> l_ c! 
221 ram 49046 + c! 75 ram 49047 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 245 <> if 0 bit or then 
cpu -> b c@ 161 <> if 1 bit or then 
cpu -> c c@ 16 <> if 2 bit or then 
cpu -> d c@ 26 <> if 3 bit or then 
cpu -> e c@ 16 <> if 4 bit or then 
cpu -> f c@ 110 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 110 h.2 [char] ] emit space then 
cpu -> h c@ 86 <> if 6 bit or then 
cpu -> l c@ 172 <> if 7 bit or then 
cpu -> i_ c@ 172 <> if 8 bit or then 
cpu -> r c@ 61 <> if 9 bit or then 
cpu -> a_ c@ 95 <> cpu -> f_ c@ 183 <> or if 10 bit or then 
cpu -> b_ c@ 182 <> cpu -> c_ c@ 23 <> or if 11 bit or then 
cpu -> d_ c@ 237 <> cpu -> e_ c@ 182 <> or if 12 bit or then 
cpu -> h_ c@ 117 <> cpu -> l_ c@ 15 <> or if 13 bit or then 
cpu -> ix h@ 59073 <> if 14 bit or then 
cpu -> iy h@ 39341 <> if 15 bit or then 
cpu -> pc h@ 49048 <> if 16 bit or then 
cpu -> sp h@ 7233 <> if 17 bit or then 
cpu -> mem_ptr h@ 44383 <> if 18 bit or then 
49046 ram + c@ 221 <> if 19 bit or then 
49047 ram + c@ 75 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4B 0001 : " 
14248 cpu -> pc h! 21912 cpu -> sp h! 
232 cpu -> a c! 46 cpu -> b c! 231 cpu -> c c! 201 cpu -> d c! 
155 cpu -> e c! 94 cpu -> f c! 147 cpu -> h c! 185 cpu -> l c! 
88 cpu -> i_ c! 59 cpu -> r c! 15065 cpu -> mem_ptr h! 
5316 cpu -> ix h! 14552 cpu -> iy h! 
29 cpu -> a_ c! 251 cpu -> f_ c! 136 cpu -> b_ c! 59 cpu -> c_ c! 
212 cpu -> d_ c! 169 cpu -> e_ c! 14 cpu -> h_ c! 232 cpu -> l_ c! 
221 ram 14248 + c! 75 ram 14249 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 232 <> if 0 bit or then 
cpu -> b c@ 46 <> if 1 bit or then 
cpu -> c c@ 155 <> if 2 bit or then 
cpu -> d c@ 201 <> if 3 bit or then 
cpu -> e c@ 155 <> if 4 bit or then 
cpu -> f c@ 94 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 94 h.2 [char] ] emit space then 
cpu -> h c@ 147 <> if 6 bit or then 
cpu -> l c@ 185 <> if 7 bit or then 
cpu -> i_ c@ 88 <> if 8 bit or then 
cpu -> r c@ 61 <> if 9 bit or then 
cpu -> a_ c@ 29 <> cpu -> f_ c@ 251 <> or if 10 bit or then 
cpu -> b_ c@ 136 <> cpu -> c_ c@ 59 <> or if 11 bit or then 
cpu -> d_ c@ 212 <> cpu -> e_ c@ 169 <> or if 12 bit or then 
cpu -> h_ c@ 14 <> cpu -> l_ c@ 232 <> or if 13 bit or then 
cpu -> ix h@ 5316 <> if 14 bit or then 
cpu -> iy h@ 14552 <> if 15 bit or then 
cpu -> pc h@ 14250 <> if 16 bit or then 
cpu -> sp h@ 21912 <> if 17 bit or then 
cpu -> mem_ptr h@ 15065 <> if 18 bit or then 
14248 ram + c@ 221 <> if 19 bit or then 
14249 ram + c@ 75 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4B 0002 : " 
486 cpu -> pc h! 19751 cpu -> sp h! 
72 cpu -> a c! 169 cpu -> b c! 251 cpu -> c c! 74 cpu -> d c! 
255 cpu -> e c! 200 cpu -> f c! 173 cpu -> h c! 254 cpu -> l c! 
253 cpu -> i_ c! 16 cpu -> r c! 64939 cpu -> mem_ptr h! 
32607 cpu -> ix h! 52368 cpu -> iy h! 
184 cpu -> a_ c! 94 cpu -> f_ c! 169 cpu -> b_ c! 150 cpu -> c_ c! 
25 cpu -> d_ c! 254 cpu -> e_ c! 33 cpu -> h_ c! 53 cpu -> l_ c! 
221 ram 486 + c! 75 ram 487 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 72 <> if 0 bit or then 
cpu -> b c@ 169 <> if 1 bit or then 
cpu -> c c@ 255 <> if 2 bit or then 
cpu -> d c@ 74 <> if 3 bit or then 
cpu -> e c@ 255 <> if 4 bit or then 
cpu -> f c@ 200 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 200 h.2 [char] ] emit space then 
cpu -> h c@ 173 <> if 6 bit or then 
cpu -> l c@ 254 <> if 7 bit or then 
cpu -> i_ c@ 253 <> if 8 bit or then 
cpu -> r c@ 18 <> if 9 bit or then 
cpu -> a_ c@ 184 <> cpu -> f_ c@ 94 <> or if 10 bit or then 
cpu -> b_ c@ 169 <> cpu -> c_ c@ 150 <> or if 11 bit or then 
cpu -> d_ c@ 25 <> cpu -> e_ c@ 254 <> or if 12 bit or then 
cpu -> h_ c@ 33 <> cpu -> l_ c@ 53 <> or if 13 bit or then 
cpu -> ix h@ 32607 <> if 14 bit or then 
cpu -> iy h@ 52368 <> if 15 bit or then 
cpu -> pc h@ 488 <> if 16 bit or then 
cpu -> sp h@ 19751 <> if 17 bit or then 
cpu -> mem_ptr h@ 64939 <> if 18 bit or then 
486 ram + c@ 221 <> if 19 bit or then 
487 ram + c@ 75 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4B 0003 : " 
1922 cpu -> pc h! 25351 cpu -> sp h! 
200 cpu -> a c! 222 cpu -> b c! 213 cpu -> c c! 247 cpu -> d c! 
166 cpu -> e c! 139 cpu -> f c! 102 cpu -> h c! 114 cpu -> l c! 
227 cpu -> i_ c! 105 cpu -> r c! 56723 cpu -> mem_ptr h! 
25701 cpu -> ix h! 51058 cpu -> iy h! 
209 cpu -> a_ c! 231 cpu -> f_ c! 194 cpu -> b_ c! 203 cpu -> c_ c! 
157 cpu -> d_ c! 124 cpu -> e_ c! 89 cpu -> h_ c! 45 cpu -> l_ c! 
221 ram 1922 + c! 75 ram 1923 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 200 <> if 0 bit or then 
cpu -> b c@ 222 <> if 1 bit or then 
cpu -> c c@ 166 <> if 2 bit or then 
cpu -> d c@ 247 <> if 3 bit or then 
cpu -> e c@ 166 <> if 4 bit or then 
cpu -> f c@ 139 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 139 h.2 [char] ] emit space then 
cpu -> h c@ 102 <> if 6 bit or then 
cpu -> l c@ 114 <> if 7 bit or then 
cpu -> i_ c@ 227 <> if 8 bit or then 
cpu -> r c@ 107 <> if 9 bit or then 
cpu -> a_ c@ 209 <> cpu -> f_ c@ 231 <> or if 10 bit or then 
cpu -> b_ c@ 194 <> cpu -> c_ c@ 203 <> or if 11 bit or then 
cpu -> d_ c@ 157 <> cpu -> e_ c@ 124 <> or if 12 bit or then 
cpu -> h_ c@ 89 <> cpu -> l_ c@ 45 <> or if 13 bit or then 
cpu -> ix h@ 25701 <> if 14 bit or then 
cpu -> iy h@ 51058 <> if 15 bit or then 
cpu -> pc h@ 1924 <> if 16 bit or then 
cpu -> sp h@ 25351 <> if 17 bit or then 
cpu -> mem_ptr h@ 56723 <> if 18 bit or then 
1922 ram + c@ 221 <> if 19 bit or then 
1923 ram + c@ 75 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4B 0004 : " 
879 cpu -> pc h! 56940 cpu -> sp h! 
124 cpu -> a c! 219 cpu -> b c! 198 cpu -> c c! 47 cpu -> d c! 
133 cpu -> e c! 211 cpu -> f c! 4 cpu -> h c! 200 cpu -> l c! 
163 cpu -> i_ c! 77 cpu -> r c! 52026 cpu -> mem_ptr h! 
15866 cpu -> ix h! 42096 cpu -> iy h! 
52 cpu -> a_ c! 96 cpu -> f_ c! 82 cpu -> b_ c! 172 cpu -> c_ c! 
46 cpu -> d_ c! 173 cpu -> e_ c! 4 cpu -> h_ c! 46 cpu -> l_ c! 
221 ram 879 + c! 75 ram 880 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 124 <> if 0 bit or then 
cpu -> b c@ 219 <> if 1 bit or then 
cpu -> c c@ 133 <> if 2 bit or then 
cpu -> d c@ 47 <> if 3 bit or then 
cpu -> e c@ 133 <> if 4 bit or then 
cpu -> f c@ 211 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 211 h.2 [char] ] emit space then 
cpu -> h c@ 4 <> if 6 bit or then 
cpu -> l c@ 200 <> if 7 bit or then 
cpu -> i_ c@ 163 <> if 8 bit or then 
cpu -> r c@ 79 <> if 9 bit or then 
cpu -> a_ c@ 52 <> cpu -> f_ c@ 96 <> or if 10 bit or then 
cpu -> b_ c@ 82 <> cpu -> c_ c@ 172 <> or if 11 bit or then 
cpu -> d_ c@ 46 <> cpu -> e_ c@ 173 <> or if 12 bit or then 
cpu -> h_ c@ 4 <> cpu -> l_ c@ 46 <> or if 13 bit or then 
cpu -> ix h@ 15866 <> if 14 bit or then 
cpu -> iy h@ 42096 <> if 15 bit or then 
cpu -> pc h@ 881 <> if 16 bit or then 
cpu -> sp h@ 56940 <> if 17 bit or then 
cpu -> mem_ptr h@ 52026 <> if 18 bit or then 
879 ram + c@ 221 <> if 19 bit or then 
880 ram + c@ 75 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4C 0000 : " 
55804 cpu -> pc h! 35219 cpu -> sp h! 
233 cpu -> a c! 115 cpu -> b c! 50 cpu -> c c! 199 cpu -> d c! 
49 cpu -> e c! 209 cpu -> f c! 202 cpu -> h c! 94 cpu -> l c! 
79 cpu -> i_ c! 11 cpu -> r c! 51266 cpu -> mem_ptr h! 
52850 cpu -> ix h! 34922 cpu -> iy h! 
33 cpu -> a_ c! 252 cpu -> f_ c! 131 cpu -> b_ c! 102 cpu -> c_ c! 
209 cpu -> d_ c! 243 cpu -> e_ c! 138 cpu -> h_ c! 127 cpu -> l_ c! 
221 ram 55804 + c! 76 ram 55805 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 233 <> if 0 bit or then 
cpu -> b c@ 115 <> if 1 bit or then 
cpu -> c c@ 206 <> if 2 bit or then 
cpu -> d c@ 199 <> if 3 bit or then 
cpu -> e c@ 49 <> if 4 bit or then 
cpu -> f c@ 209 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 209 h.2 [char] ] emit space then 
cpu -> h c@ 202 <> if 6 bit or then 
cpu -> l c@ 94 <> if 7 bit or then 
cpu -> i_ c@ 79 <> if 8 bit or then 
cpu -> r c@ 13 <> if 9 bit or then 
cpu -> a_ c@ 33 <> cpu -> f_ c@ 252 <> or if 10 bit or then 
cpu -> b_ c@ 131 <> cpu -> c_ c@ 102 <> or if 11 bit or then 
cpu -> d_ c@ 209 <> cpu -> e_ c@ 243 <> or if 12 bit or then 
cpu -> h_ c@ 138 <> cpu -> l_ c@ 127 <> or if 13 bit or then 
cpu -> ix h@ 52850 <> if 14 bit or then 
cpu -> iy h@ 34922 <> if 15 bit or then 
cpu -> pc h@ 55806 <> if 16 bit or then 
cpu -> sp h@ 35219 <> if 17 bit or then 
cpu -> mem_ptr h@ 51266 <> if 18 bit or then 
55804 ram + c@ 221 <> if 19 bit or then 
55805 ram + c@ 76 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4C 0001 : " 
3162 cpu -> pc h! 54969 cpu -> sp h! 
62 cpu -> a c! 125 cpu -> b c! 187 cpu -> c c! 64 cpu -> d c! 
229 cpu -> e c! 170 cpu -> f c! 133 cpu -> h c! 192 cpu -> l c! 
1 cpu -> i_ c! 91 cpu -> r c! 22776 cpu -> mem_ptr h! 
29896 cpu -> ix h! 1990 cpu -> iy h! 
96 cpu -> a_ c! 60 cpu -> f_ c! 122 cpu -> b_ c! 169 cpu -> c_ c! 
48 cpu -> d_ c! 73 cpu -> e_ c! 6 cpu -> h_ c! 88 cpu -> l_ c! 
221 ram 3162 + c! 76 ram 3163 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 62 <> if 0 bit or then 
cpu -> b c@ 125 <> if 1 bit or then 
cpu -> c c@ 116 <> if 2 bit or then 
cpu -> d c@ 64 <> if 3 bit or then 
cpu -> e c@ 229 <> if 4 bit or then 
cpu -> f c@ 170 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 170 h.2 [char] ] emit space then 
cpu -> h c@ 133 <> if 6 bit or then 
cpu -> l c@ 192 <> if 7 bit or then 
cpu -> i_ c@ 1 <> if 8 bit or then 
cpu -> r c@ 93 <> if 9 bit or then 
cpu -> a_ c@ 96 <> cpu -> f_ c@ 60 <> or if 10 bit or then 
cpu -> b_ c@ 122 <> cpu -> c_ c@ 169 <> or if 11 bit or then 
cpu -> d_ c@ 48 <> cpu -> e_ c@ 73 <> or if 12 bit or then 
cpu -> h_ c@ 6 <> cpu -> l_ c@ 88 <> or if 13 bit or then 
cpu -> ix h@ 29896 <> if 14 bit or then 
cpu -> iy h@ 1990 <> if 15 bit or then 
cpu -> pc h@ 3164 <> if 16 bit or then 
cpu -> sp h@ 54969 <> if 17 bit or then 
cpu -> mem_ptr h@ 22776 <> if 18 bit or then 
3162 ram + c@ 221 <> if 19 bit or then 
3163 ram + c@ 76 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4C 0002 : " 
5246 cpu -> pc h! 41810 cpu -> sp h! 
90 cpu -> a c! 52 cpu -> b c! 77 cpu -> c c! 69 cpu -> d c! 
210 cpu -> e c! 11 cpu -> f c! 243 cpu -> h c! 70 cpu -> l c! 
239 cpu -> i_ c! 95 cpu -> r c! 64422 cpu -> mem_ptr h! 
9580 cpu -> ix h! 9054 cpu -> iy h! 
211 cpu -> a_ c! 17 cpu -> f_ c! 158 cpu -> b_ c! 242 cpu -> c_ c! 
34 cpu -> d_ c! 172 cpu -> e_ c! 179 cpu -> h_ c! 207 cpu -> l_ c! 
221 ram 5246 + c! 76 ram 5247 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 90 <> if 0 bit or then 
cpu -> b c@ 52 <> if 1 bit or then 
cpu -> c c@ 37 <> if 2 bit or then 
cpu -> d c@ 69 <> if 3 bit or then 
cpu -> e c@ 210 <> if 4 bit or then 
cpu -> f c@ 11 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 11 h.2 [char] ] emit space then 
cpu -> h c@ 243 <> if 6 bit or then 
cpu -> l c@ 70 <> if 7 bit or then 
cpu -> i_ c@ 239 <> if 8 bit or then 
cpu -> r c@ 97 <> if 9 bit or then 
cpu -> a_ c@ 211 <> cpu -> f_ c@ 17 <> or if 10 bit or then 
cpu -> b_ c@ 158 <> cpu -> c_ c@ 242 <> or if 11 bit or then 
cpu -> d_ c@ 34 <> cpu -> e_ c@ 172 <> or if 12 bit or then 
cpu -> h_ c@ 179 <> cpu -> l_ c@ 207 <> or if 13 bit or then 
cpu -> ix h@ 9580 <> if 14 bit or then 
cpu -> iy h@ 9054 <> if 15 bit or then 
cpu -> pc h@ 5248 <> if 16 bit or then 
cpu -> sp h@ 41810 <> if 17 bit or then 
cpu -> mem_ptr h@ 64422 <> if 18 bit or then 
5246 ram + c@ 221 <> if 19 bit or then 
5247 ram + c@ 76 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4C 0003 : " 
41384 cpu -> pc h! 58807 cpu -> sp h! 
112 cpu -> a c! 243 cpu -> b c! 25 cpu -> c c! 188 cpu -> d c! 
8 cpu -> e c! 84 cpu -> f c! 252 cpu -> h c! 34 cpu -> l c! 
175 cpu -> i_ c! 106 cpu -> r c! 37580 cpu -> mem_ptr h! 
44290 cpu -> ix h! 39929 cpu -> iy h! 
62 cpu -> a_ c! 106 cpu -> f_ c! 223 cpu -> b_ c! 241 cpu -> c_ c! 
73 cpu -> d_ c! 138 cpu -> e_ c! 149 cpu -> h_ c! 135 cpu -> l_ c! 
221 ram 41384 + c! 76 ram 41385 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 112 <> if 0 bit or then 
cpu -> b c@ 243 <> if 1 bit or then 
cpu -> c c@ 173 <> if 2 bit or then 
cpu -> d c@ 188 <> if 3 bit or then 
cpu -> e c@ 8 <> if 4 bit or then 
cpu -> f c@ 84 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 84 h.2 [char] ] emit space then 
cpu -> h c@ 252 <> if 6 bit or then 
cpu -> l c@ 34 <> if 7 bit or then 
cpu -> i_ c@ 175 <> if 8 bit or then 
cpu -> r c@ 108 <> if 9 bit or then 
cpu -> a_ c@ 62 <> cpu -> f_ c@ 106 <> or if 10 bit or then 
cpu -> b_ c@ 223 <> cpu -> c_ c@ 241 <> or if 11 bit or then 
cpu -> d_ c@ 73 <> cpu -> e_ c@ 138 <> or if 12 bit or then 
cpu -> h_ c@ 149 <> cpu -> l_ c@ 135 <> or if 13 bit or then 
cpu -> ix h@ 44290 <> if 14 bit or then 
cpu -> iy h@ 39929 <> if 15 bit or then 
cpu -> pc h@ 41386 <> if 16 bit or then 
cpu -> sp h@ 58807 <> if 17 bit or then 
cpu -> mem_ptr h@ 37580 <> if 18 bit or then 
41384 ram + c@ 221 <> if 19 bit or then 
41385 ram + c@ 76 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4C 0004 : " 
36889 cpu -> pc h! 40596 cpu -> sp h! 
191 cpu -> a c! 37 cpu -> b c! 87 cpu -> c c! 38 cpu -> d c! 
34 cpu -> e c! 217 cpu -> f c! 118 cpu -> h c! 143 cpu -> l c! 
20 cpu -> i_ c! 89 cpu -> r c! 3742 cpu -> mem_ptr h! 
42979 cpu -> ix h! 780 cpu -> iy h! 
195 cpu -> a_ c! 159 cpu -> f_ c! 243 cpu -> b_ c! 14 cpu -> c_ c! 
152 cpu -> d_ c! 251 cpu -> e_ c! 202 cpu -> h_ c! 190 cpu -> l_ c! 
221 ram 36889 + c! 76 ram 36890 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 191 <> if 0 bit or then 
cpu -> b c@ 37 <> if 1 bit or then 
cpu -> c c@ 167 <> if 2 bit or then 
cpu -> d c@ 38 <> if 3 bit or then 
cpu -> e c@ 34 <> if 4 bit or then 
cpu -> f c@ 217 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 217 h.2 [char] ] emit space then 
cpu -> h c@ 118 <> if 6 bit or then 
cpu -> l c@ 143 <> if 7 bit or then 
cpu -> i_ c@ 20 <> if 8 bit or then 
cpu -> r c@ 91 <> if 9 bit or then 
cpu -> a_ c@ 195 <> cpu -> f_ c@ 159 <> or if 10 bit or then 
cpu -> b_ c@ 243 <> cpu -> c_ c@ 14 <> or if 11 bit or then 
cpu -> d_ c@ 152 <> cpu -> e_ c@ 251 <> or if 12 bit or then 
cpu -> h_ c@ 202 <> cpu -> l_ c@ 190 <> or if 13 bit or then 
cpu -> ix h@ 42979 <> if 14 bit or then 
cpu -> iy h@ 780 <> if 15 bit or then 
cpu -> pc h@ 36891 <> if 16 bit or then 
cpu -> sp h@ 40596 <> if 17 bit or then 
cpu -> mem_ptr h@ 3742 <> if 18 bit or then 
36889 ram + c@ 221 <> if 19 bit or then 
36890 ram + c@ 76 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4D 0000 : " 
31185 cpu -> pc h! 12564 cpu -> sp h! 
2 cpu -> a c! 198 cpu -> b c! 87 cpu -> c c! 5 cpu -> d c! 
236 cpu -> e c! 185 cpu -> f c! 120 cpu -> h c! 10 cpu -> l c! 
22 cpu -> i_ c! 117 cpu -> r c! 58329 cpu -> mem_ptr h! 
52708 cpu -> ix h! 25736 cpu -> iy h! 
222 cpu -> a_ c! 245 cpu -> f_ c! 140 cpu -> b_ c! 56 cpu -> c_ c! 
123 cpu -> d_ c! 71 cpu -> e_ c! 170 cpu -> h_ c! 74 cpu -> l_ c! 
221 ram 31185 + c! 77 ram 31186 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 2 <> if 0 bit or then 
cpu -> b c@ 198 <> if 1 bit or then 
cpu -> c c@ 228 <> if 2 bit or then 
cpu -> d c@ 5 <> if 3 bit or then 
cpu -> e c@ 236 <> if 4 bit or then 
cpu -> f c@ 185 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 185 h.2 [char] ] emit space then 
cpu -> h c@ 120 <> if 6 bit or then 
cpu -> l c@ 10 <> if 7 bit or then 
cpu -> i_ c@ 22 <> if 8 bit or then 
cpu -> r c@ 119 <> if 9 bit or then 
cpu -> a_ c@ 222 <> cpu -> f_ c@ 245 <> or if 10 bit or then 
cpu -> b_ c@ 140 <> cpu -> c_ c@ 56 <> or if 11 bit or then 
cpu -> d_ c@ 123 <> cpu -> e_ c@ 71 <> or if 12 bit or then 
cpu -> h_ c@ 170 <> cpu -> l_ c@ 74 <> or if 13 bit or then 
cpu -> ix h@ 52708 <> if 14 bit or then 
cpu -> iy h@ 25736 <> if 15 bit or then 
cpu -> pc h@ 31187 <> if 16 bit or then 
cpu -> sp h@ 12564 <> if 17 bit or then 
cpu -> mem_ptr h@ 58329 <> if 18 bit or then 
31185 ram + c@ 221 <> if 19 bit or then 
31186 ram + c@ 77 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4D 0001 : " 
34458 cpu -> pc h! 10157 cpu -> sp h! 
239 cpu -> a c! 76 cpu -> b c! 61 cpu -> c c! 11 cpu -> d c! 
116 cpu -> e c! 54 cpu -> f c! 123 cpu -> h c! 102 cpu -> l c! 
221 cpu -> i_ c! 112 cpu -> r c! 18232 cpu -> mem_ptr h! 
20140 cpu -> ix h! 12140 cpu -> iy h! 
90 cpu -> a_ c! 152 cpu -> f_ c! 10 cpu -> b_ c! 229 cpu -> c_ c! 
159 cpu -> d_ c! 217 cpu -> e_ c! 55 cpu -> h_ c! 96 cpu -> l_ c! 
221 ram 34458 + c! 77 ram 34459 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 239 <> if 0 bit or then 
cpu -> b c@ 76 <> if 1 bit or then 
cpu -> c c@ 172 <> if 2 bit or then 
cpu -> d c@ 11 <> if 3 bit or then 
cpu -> e c@ 116 <> if 4 bit or then 
cpu -> f c@ 54 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 54 h.2 [char] ] emit space then 
cpu -> h c@ 123 <> if 6 bit or then 
cpu -> l c@ 102 <> if 7 bit or then 
cpu -> i_ c@ 221 <> if 8 bit or then 
cpu -> r c@ 114 <> if 9 bit or then 
cpu -> a_ c@ 90 <> cpu -> f_ c@ 152 <> or if 10 bit or then 
cpu -> b_ c@ 10 <> cpu -> c_ c@ 229 <> or if 11 bit or then 
cpu -> d_ c@ 159 <> cpu -> e_ c@ 217 <> or if 12 bit or then 
cpu -> h_ c@ 55 <> cpu -> l_ c@ 96 <> or if 13 bit or then 
cpu -> ix h@ 20140 <> if 14 bit or then 
cpu -> iy h@ 12140 <> if 15 bit or then 
cpu -> pc h@ 34460 <> if 16 bit or then 
cpu -> sp h@ 10157 <> if 17 bit or then 
cpu -> mem_ptr h@ 18232 <> if 18 bit or then 
34458 ram + c@ 221 <> if 19 bit or then 
34459 ram + c@ 77 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4D 0002 : " 
47567 cpu -> pc h! 22936 cpu -> sp h! 
156 cpu -> a c! 9 cpu -> b c! 10 cpu -> c c! 210 cpu -> d c! 
116 cpu -> e c! 217 cpu -> f c! 206 cpu -> h c! 141 cpu -> l c! 
51 cpu -> i_ c! 34 cpu -> r c! 65405 cpu -> mem_ptr h! 
11835 cpu -> ix h! 56936 cpu -> iy h! 
101 cpu -> a_ c! 59 cpu -> f_ c! 88 cpu -> b_ c! 119 cpu -> c_ c! 
179 cpu -> d_ c! 74 cpu -> e_ c! 112 cpu -> h_ c! 210 cpu -> l_ c! 
221 ram 47567 + c! 77 ram 47568 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 156 <> if 0 bit or then 
cpu -> b c@ 9 <> if 1 bit or then 
cpu -> c c@ 59 <> if 2 bit or then 
cpu -> d c@ 210 <> if 3 bit or then 
cpu -> e c@ 116 <> if 4 bit or then 
cpu -> f c@ 217 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 217 h.2 [char] ] emit space then 
cpu -> h c@ 206 <> if 6 bit or then 
cpu -> l c@ 141 <> if 7 bit or then 
cpu -> i_ c@ 51 <> if 8 bit or then 
cpu -> r c@ 36 <> if 9 bit or then 
cpu -> a_ c@ 101 <> cpu -> f_ c@ 59 <> or if 10 bit or then 
cpu -> b_ c@ 88 <> cpu -> c_ c@ 119 <> or if 11 bit or then 
cpu -> d_ c@ 179 <> cpu -> e_ c@ 74 <> or if 12 bit or then 
cpu -> h_ c@ 112 <> cpu -> l_ c@ 210 <> or if 13 bit or then 
cpu -> ix h@ 11835 <> if 14 bit or then 
cpu -> iy h@ 56936 <> if 15 bit or then 
cpu -> pc h@ 47569 <> if 16 bit or then 
cpu -> sp h@ 22936 <> if 17 bit or then 
cpu -> mem_ptr h@ 65405 <> if 18 bit or then 
47567 ram + c@ 221 <> if 19 bit or then 
47568 ram + c@ 77 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4D 0003 : " 
25396 cpu -> pc h! 17290 cpu -> sp h! 
157 cpu -> a c! 210 cpu -> b c! 40 cpu -> c c! 133 cpu -> d c! 
28 cpu -> e c! 103 cpu -> f c! 165 cpu -> h c! 120 cpu -> l c! 
200 cpu -> i_ c! 41 cpu -> r c! 2722 cpu -> mem_ptr h! 
1129 cpu -> ix h! 43813 cpu -> iy h! 
180 cpu -> a_ c! 81 cpu -> f_ c! 85 cpu -> b_ c! 154 cpu -> c_ c! 
162 cpu -> d_ c! 85 cpu -> e_ c! 35 cpu -> h_ c! 81 cpu -> l_ c! 
221 ram 25396 + c! 77 ram 25397 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 157 <> if 0 bit or then 
cpu -> b c@ 210 <> if 1 bit or then 
cpu -> c c@ 105 <> if 2 bit or then 
cpu -> d c@ 133 <> if 3 bit or then 
cpu -> e c@ 28 <> if 4 bit or then 
cpu -> f c@ 103 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 103 h.2 [char] ] emit space then 
cpu -> h c@ 165 <> if 6 bit or then 
cpu -> l c@ 120 <> if 7 bit or then 
cpu -> i_ c@ 200 <> if 8 bit or then 
cpu -> r c@ 43 <> if 9 bit or then 
cpu -> a_ c@ 180 <> cpu -> f_ c@ 81 <> or if 10 bit or then 
cpu -> b_ c@ 85 <> cpu -> c_ c@ 154 <> or if 11 bit or then 
cpu -> d_ c@ 162 <> cpu -> e_ c@ 85 <> or if 12 bit or then 
cpu -> h_ c@ 35 <> cpu -> l_ c@ 81 <> or if 13 bit or then 
cpu -> ix h@ 1129 <> if 14 bit or then 
cpu -> iy h@ 43813 <> if 15 bit or then 
cpu -> pc h@ 25398 <> if 16 bit or then 
cpu -> sp h@ 17290 <> if 17 bit or then 
cpu -> mem_ptr h@ 2722 <> if 18 bit or then 
25396 ram + c@ 221 <> if 19 bit or then 
25397 ram + c@ 77 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4D 0004 : " 
10939 cpu -> pc h! 19417 cpu -> sp h! 
55 cpu -> a c! 14 cpu -> b c! 0 cpu -> c c! 131 cpu -> d c! 
192 cpu -> e c! 147 cpu -> f c! 236 cpu -> h c! 249 cpu -> l c! 
19 cpu -> i_ c! 127 cpu -> r c! 31384 cpu -> mem_ptr h! 
28846 cpu -> ix h! 32650 cpu -> iy h! 
252 cpu -> a_ c! 126 cpu -> f_ c! 129 cpu -> b_ c! 161 cpu -> c_ c! 
138 cpu -> d_ c! 8 cpu -> e_ c! 247 cpu -> h_ c! 203 cpu -> l_ c! 
221 ram 10939 + c! 77 ram 10940 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 55 <> if 0 bit or then 
cpu -> b c@ 14 <> if 1 bit or then 
cpu -> c c@ 174 <> if 2 bit or then 
cpu -> d c@ 131 <> if 3 bit or then 
cpu -> e c@ 192 <> if 4 bit or then 
cpu -> f c@ 147 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 147 h.2 [char] ] emit space then 
cpu -> h c@ 236 <> if 6 bit or then 
cpu -> l c@ 249 <> if 7 bit or then 
cpu -> i_ c@ 19 <> if 8 bit or then 
cpu -> r c@ 1 <> if 9 bit or then 
cpu -> a_ c@ 252 <> cpu -> f_ c@ 126 <> or if 10 bit or then 
cpu -> b_ c@ 129 <> cpu -> c_ c@ 161 <> or if 11 bit or then 
cpu -> d_ c@ 138 <> cpu -> e_ c@ 8 <> or if 12 bit or then 
cpu -> h_ c@ 247 <> cpu -> l_ c@ 203 <> or if 13 bit or then 
cpu -> ix h@ 28846 <> if 14 bit or then 
cpu -> iy h@ 32650 <> if 15 bit or then 
cpu -> pc h@ 10941 <> if 16 bit or then 
cpu -> sp h@ 19417 <> if 17 bit or then 
cpu -> mem_ptr h@ 31384 <> if 18 bit or then 
10939 ram + c@ 221 <> if 19 bit or then 
10940 ram + c@ 77 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4E 0000 : " 
1223 cpu -> pc h! 46770 cpu -> sp h! 
95 cpu -> a c! 32 cpu -> b c! 45 cpu -> c c! 243 cpu -> d c! 
112 cpu -> e c! 192 cpu -> f c! 78 cpu -> h c! 30 cpu -> l c! 
20 cpu -> i_ c! 8 cpu -> r c! 44459 cpu -> mem_ptr h! 
9524 cpu -> ix h! 56704 cpu -> iy h! 
228 cpu -> a_ c! 213 cpu -> f_ c! 173 cpu -> b_ c! 177 cpu -> c_ c! 
21 cpu -> d_ c! 142 cpu -> e_ c! 29 cpu -> h_ c! 204 cpu -> l_ c! 
221 ram 1223 + c! 78 ram 1224 + c! 213 ram 1225 + c! 29 ram 9481 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 95 <> if 0 bit or then 
cpu -> b c@ 32 <> if 1 bit or then 
cpu -> c c@ 29 <> if 2 bit or then 
cpu -> d c@ 243 <> if 3 bit or then 
cpu -> e c@ 112 <> if 4 bit or then 
cpu -> f c@ 192 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 192 h.2 [char] ] emit space then 
cpu -> h c@ 78 <> if 6 bit or then 
cpu -> l c@ 30 <> if 7 bit or then 
cpu -> i_ c@ 20 <> if 8 bit or then 
cpu -> r c@ 10 <> if 9 bit or then 
cpu -> a_ c@ 228 <> cpu -> f_ c@ 213 <> or if 10 bit or then 
cpu -> b_ c@ 173 <> cpu -> c_ c@ 177 <> or if 11 bit or then 
cpu -> d_ c@ 21 <> cpu -> e_ c@ 142 <> or if 12 bit or then 
cpu -> h_ c@ 29 <> cpu -> l_ c@ 204 <> or if 13 bit or then 
cpu -> ix h@ 9524 <> if 14 bit or then 
cpu -> iy h@ 56704 <> if 15 bit or then 
cpu -> pc h@ 1226 <> if 16 bit or then 
cpu -> sp h@ 46770 <> if 17 bit or then 
cpu -> mem_ptr h@ 9481 <> if 18 bit or then 
1223 ram + c@ 221 <> if 19 bit or then 
1224 ram + c@ 78 <> if 19 bit or then 
1225 ram + c@ 213 <> if 19 bit or then 
9481 ram + c@ 29 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4E 0001 : " 
37520 cpu -> pc h! 10307 cpu -> sp h! 
49 cpu -> a c! 88 cpu -> b c! 128 cpu -> c c! 165 cpu -> d c! 
162 cpu -> e c! 162 cpu -> f c! 192 cpu -> h c! 23 cpu -> l c! 
228 cpu -> i_ c! 93 cpu -> r c! 47100 cpu -> mem_ptr h! 
27818 cpu -> ix h! 11229 cpu -> iy h! 
92 cpu -> a_ c! 148 cpu -> f_ c! 56 cpu -> b_ c! 189 cpu -> c_ c! 
141 cpu -> d_ c! 254 cpu -> e_ c! 90 cpu -> h_ c! 229 cpu -> l_ c! 
45 ram 27809 + c! 221 ram 37520 + c! 78 ram 37521 + c! 247 ram 37522 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 49 <> if 0 bit or then 
cpu -> b c@ 88 <> if 1 bit or then 
cpu -> c c@ 45 <> if 2 bit or then 
cpu -> d c@ 165 <> if 3 bit or then 
cpu -> e c@ 162 <> if 4 bit or then 
cpu -> f c@ 162 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 162 h.2 [char] ] emit space then 
cpu -> h c@ 192 <> if 6 bit or then 
cpu -> l c@ 23 <> if 7 bit or then 
cpu -> i_ c@ 228 <> if 8 bit or then 
cpu -> r c@ 95 <> if 9 bit or then 
cpu -> a_ c@ 92 <> cpu -> f_ c@ 148 <> or if 10 bit or then 
cpu -> b_ c@ 56 <> cpu -> c_ c@ 189 <> or if 11 bit or then 
cpu -> d_ c@ 141 <> cpu -> e_ c@ 254 <> or if 12 bit or then 
cpu -> h_ c@ 90 <> cpu -> l_ c@ 229 <> or if 13 bit or then 
cpu -> ix h@ 27818 <> if 14 bit or then 
cpu -> iy h@ 11229 <> if 15 bit or then 
cpu -> pc h@ 37523 <> if 16 bit or then 
cpu -> sp h@ 10307 <> if 17 bit or then 
cpu -> mem_ptr h@ 27809 <> if 18 bit or then 
27809 ram + c@ 45 <> if 19 bit or then 
37520 ram + c@ 221 <> if 19 bit or then 
37521 ram + c@ 78 <> if 19 bit or then 
37522 ram + c@ 247 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4E 0002 : " 
28990 cpu -> pc h! 52794 cpu -> sp h! 
76 cpu -> a c! 155 cpu -> b c! 55 cpu -> c c! 148 cpu -> d c! 
194 cpu -> e c! 225 cpu -> f c! 0 cpu -> h c! 202 cpu -> l c! 
100 cpu -> i_ c! 20 cpu -> r c! 56303 cpu -> mem_ptr h! 
4218 cpu -> ix h! 47165 cpu -> iy h! 
125 cpu -> a_ c! 61 cpu -> f_ c! 109 cpu -> b_ c! 70 cpu -> c_ c! 
136 cpu -> d_ c! 89 cpu -> e_ c! 207 cpu -> h_ c! 39 cpu -> l_ c! 
58 ram 4297 + c! 221 ram 28990 + c! 78 ram 28991 + c! 79 ram 28992 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 76 <> if 0 bit or then 
cpu -> b c@ 155 <> if 1 bit or then 
cpu -> c c@ 58 <> if 2 bit or then 
cpu -> d c@ 148 <> if 3 bit or then 
cpu -> e c@ 194 <> if 4 bit or then 
cpu -> f c@ 225 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 225 h.2 [char] ] emit space then 
cpu -> h c@ 0 <> if 6 bit or then 
cpu -> l c@ 202 <> if 7 bit or then 
cpu -> i_ c@ 100 <> if 8 bit or then 
cpu -> r c@ 22 <> if 9 bit or then 
cpu -> a_ c@ 125 <> cpu -> f_ c@ 61 <> or if 10 bit or then 
cpu -> b_ c@ 109 <> cpu -> c_ c@ 70 <> or if 11 bit or then 
cpu -> d_ c@ 136 <> cpu -> e_ c@ 89 <> or if 12 bit or then 
cpu -> h_ c@ 207 <> cpu -> l_ c@ 39 <> or if 13 bit or then 
cpu -> ix h@ 4218 <> if 14 bit or then 
cpu -> iy h@ 47165 <> if 15 bit or then 
cpu -> pc h@ 28993 <> if 16 bit or then 
cpu -> sp h@ 52794 <> if 17 bit or then 
cpu -> mem_ptr h@ 4297 <> if 18 bit or then 
4297 ram + c@ 58 <> if 19 bit or then 
28990 ram + c@ 221 <> if 19 bit or then 
28991 ram + c@ 78 <> if 19 bit or then 
28992 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4E 0003 : " 
57846 cpu -> pc h! 32738 cpu -> sp h! 
213 cpu -> a c! 209 cpu -> b c! 197 cpu -> c c! 32 cpu -> d c! 
139 cpu -> e c! 8 cpu -> f c! 249 cpu -> h c! 220 cpu -> l c! 
123 cpu -> i_ c! 33 cpu -> r c! 37780 cpu -> mem_ptr h! 
35405 cpu -> ix h! 37975 cpu -> iy h! 
222 cpu -> a_ c! 238 cpu -> f_ c! 173 cpu -> b_ c! 184 cpu -> c_ c! 
191 cpu -> d_ c! 142 cpu -> e_ c! 111 cpu -> h_ c! 5 cpu -> l_ c! 
110 ram 35359 + c! 221 ram 57846 + c! 78 ram 57847 + c! 210 ram 57848 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 213 <> if 0 bit or then 
cpu -> b c@ 209 <> if 1 bit or then 
cpu -> c c@ 110 <> if 2 bit or then 
cpu -> d c@ 32 <> if 3 bit or then 
cpu -> e c@ 139 <> if 4 bit or then 
cpu -> f c@ 8 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 8 h.2 [char] ] emit space then 
cpu -> h c@ 249 <> if 6 bit or then 
cpu -> l c@ 220 <> if 7 bit or then 
cpu -> i_ c@ 123 <> if 8 bit or then 
cpu -> r c@ 35 <> if 9 bit or then 
cpu -> a_ c@ 222 <> cpu -> f_ c@ 238 <> or if 10 bit or then 
cpu -> b_ c@ 173 <> cpu -> c_ c@ 184 <> or if 11 bit or then 
cpu -> d_ c@ 191 <> cpu -> e_ c@ 142 <> or if 12 bit or then 
cpu -> h_ c@ 111 <> cpu -> l_ c@ 5 <> or if 13 bit or then 
cpu -> ix h@ 35405 <> if 14 bit or then 
cpu -> iy h@ 37975 <> if 15 bit or then 
cpu -> pc h@ 57849 <> if 16 bit or then 
cpu -> sp h@ 32738 <> if 17 bit or then 
cpu -> mem_ptr h@ 35359 <> if 18 bit or then 
35359 ram + c@ 110 <> if 19 bit or then 
57846 ram + c@ 221 <> if 19 bit or then 
57847 ram + c@ 78 <> if 19 bit or then 
57848 ram + c@ 210 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4E 0004 : " 
10419 cpu -> pc h! 45307 cpu -> sp h! 
237 cpu -> a c! 48 cpu -> b c! 230 cpu -> c c! 150 cpu -> d c! 
83 cpu -> e c! 77 cpu -> f c! 59 cpu -> h c! 231 cpu -> l c! 
161 cpu -> i_ c! 27 cpu -> r c! 65052 cpu -> mem_ptr h! 
4407 cpu -> ix h! 12460 cpu -> iy h! 
30 cpu -> a_ c! 31 cpu -> f_ c! 2 cpu -> b_ c! 9 cpu -> c_ c! 
162 cpu -> d_ c! 237 cpu -> e_ c! 167 cpu -> h_ c! 77 cpu -> l_ c! 
124 ram 4306 + c! 221 ram 10419 + c! 78 ram 10420 + c! 155 ram 10421 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 237 <> if 0 bit or then 
cpu -> b c@ 48 <> if 1 bit or then 
cpu -> c c@ 124 <> if 2 bit or then 
cpu -> d c@ 150 <> if 3 bit or then 
cpu -> e c@ 83 <> if 4 bit or then 
cpu -> f c@ 77 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 77 h.2 [char] ] emit space then 
cpu -> h c@ 59 <> if 6 bit or then 
cpu -> l c@ 231 <> if 7 bit or then 
cpu -> i_ c@ 161 <> if 8 bit or then 
cpu -> r c@ 29 <> if 9 bit or then 
cpu -> a_ c@ 30 <> cpu -> f_ c@ 31 <> or if 10 bit or then 
cpu -> b_ c@ 2 <> cpu -> c_ c@ 9 <> or if 11 bit or then 
cpu -> d_ c@ 162 <> cpu -> e_ c@ 237 <> or if 12 bit or then 
cpu -> h_ c@ 167 <> cpu -> l_ c@ 77 <> or if 13 bit or then 
cpu -> ix h@ 4407 <> if 14 bit or then 
cpu -> iy h@ 12460 <> if 15 bit or then 
cpu -> pc h@ 10422 <> if 16 bit or then 
cpu -> sp h@ 45307 <> if 17 bit or then 
cpu -> mem_ptr h@ 4306 <> if 18 bit or then 
4306 ram + c@ 124 <> if 19 bit or then 
10419 ram + c@ 221 <> if 19 bit or then 
10420 ram + c@ 78 <> if 19 bit or then 
10421 ram + c@ 155 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4F 0000 : " 
10494 cpu -> pc h! 39481 cpu -> sp h! 
195 cpu -> a c! 209 cpu -> b c! 46 cpu -> c c! 145 cpu -> d c! 
230 cpu -> e c! 38 cpu -> f c! 227 cpu -> h c! 171 cpu -> l c! 
144 cpu -> i_ c! 9 cpu -> r c! 29360 cpu -> mem_ptr h! 
30334 cpu -> ix h! 36703 cpu -> iy h! 
35 cpu -> a_ c! 60 cpu -> f_ c! 170 cpu -> b_ c! 55 cpu -> c_ c! 
137 cpu -> d_ c! 45 cpu -> e_ c! 66 cpu -> h_ c! 54 cpu -> l_ c! 
221 ram 10494 + c! 79 ram 10495 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 195 <> if 0 bit or then 
cpu -> b c@ 209 <> if 1 bit or then 
cpu -> c c@ 195 <> if 2 bit or then 
cpu -> d c@ 145 <> if 3 bit or then 
cpu -> e c@ 230 <> if 4 bit or then 
cpu -> f c@ 38 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 38 h.2 [char] ] emit space then 
cpu -> h c@ 227 <> if 6 bit or then 
cpu -> l c@ 171 <> if 7 bit or then 
cpu -> i_ c@ 144 <> if 8 bit or then 
cpu -> r c@ 11 <> if 9 bit or then 
cpu -> a_ c@ 35 <> cpu -> f_ c@ 60 <> or if 10 bit or then 
cpu -> b_ c@ 170 <> cpu -> c_ c@ 55 <> or if 11 bit or then 
cpu -> d_ c@ 137 <> cpu -> e_ c@ 45 <> or if 12 bit or then 
cpu -> h_ c@ 66 <> cpu -> l_ c@ 54 <> or if 13 bit or then 
cpu -> ix h@ 30334 <> if 14 bit or then 
cpu -> iy h@ 36703 <> if 15 bit or then 
cpu -> pc h@ 10496 <> if 16 bit or then 
cpu -> sp h@ 39481 <> if 17 bit or then 
cpu -> mem_ptr h@ 29360 <> if 18 bit or then 
10494 ram + c@ 221 <> if 19 bit or then 
10495 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4F 0001 : " 
22809 cpu -> pc h! 27842 cpu -> sp h! 
224 cpu -> a c! 189 cpu -> b c! 214 cpu -> c c! 106 cpu -> d c! 
242 cpu -> e c! 5 cpu -> f c! 142 cpu -> h c! 51 cpu -> l c! 
87 cpu -> i_ c! 18 cpu -> r c! 65230 cpu -> mem_ptr h! 
49643 cpu -> ix h! 25545 cpu -> iy h! 
202 cpu -> a_ c! 83 cpu -> f_ c! 131 cpu -> b_ c! 2 cpu -> c_ c! 
227 cpu -> d_ c! 174 cpu -> e_ c! 56 cpu -> h_ c! 68 cpu -> l_ c! 
221 ram 22809 + c! 79 ram 22810 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 224 <> if 0 bit or then 
cpu -> b c@ 189 <> if 1 bit or then 
cpu -> c c@ 224 <> if 2 bit or then 
cpu -> d c@ 106 <> if 3 bit or then 
cpu -> e c@ 242 <> if 4 bit or then 
cpu -> f c@ 5 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 5 h.2 [char] ] emit space then 
cpu -> h c@ 142 <> if 6 bit or then 
cpu -> l c@ 51 <> if 7 bit or then 
cpu -> i_ c@ 87 <> if 8 bit or then 
cpu -> r c@ 20 <> if 9 bit or then 
cpu -> a_ c@ 202 <> cpu -> f_ c@ 83 <> or if 10 bit or then 
cpu -> b_ c@ 131 <> cpu -> c_ c@ 2 <> or if 11 bit or then 
cpu -> d_ c@ 227 <> cpu -> e_ c@ 174 <> or if 12 bit or then 
cpu -> h_ c@ 56 <> cpu -> l_ c@ 68 <> or if 13 bit or then 
cpu -> ix h@ 49643 <> if 14 bit or then 
cpu -> iy h@ 25545 <> if 15 bit or then 
cpu -> pc h@ 22811 <> if 16 bit or then 
cpu -> sp h@ 27842 <> if 17 bit or then 
cpu -> mem_ptr h@ 65230 <> if 18 bit or then 
22809 ram + c@ 221 <> if 19 bit or then 
22810 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4F 0002 : " 
24423 cpu -> pc h! 10572 cpu -> sp h! 
244 cpu -> a c! 119 cpu -> b c! 27 cpu -> c c! 206 cpu -> d c! 
36 cpu -> e c! 183 cpu -> f c! 239 cpu -> h c! 128 cpu -> l c! 
189 cpu -> i_ c! 22 cpu -> r c! 19101 cpu -> mem_ptr h! 
28331 cpu -> ix h! 53165 cpu -> iy h! 
102 cpu -> a_ c! 251 cpu -> f_ c! 78 cpu -> b_ c! 93 cpu -> c_ c! 
89 cpu -> d_ c! 171 cpu -> e_ c! 113 cpu -> h_ c! 197 cpu -> l_ c! 
221 ram 24423 + c! 79 ram 24424 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 244 <> if 0 bit or then 
cpu -> b c@ 119 <> if 1 bit or then 
cpu -> c c@ 244 <> if 2 bit or then 
cpu -> d c@ 206 <> if 3 bit or then 
cpu -> e c@ 36 <> if 4 bit or then 
cpu -> f c@ 183 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 183 h.2 [char] ] emit space then 
cpu -> h c@ 239 <> if 6 bit or then 
cpu -> l c@ 128 <> if 7 bit or then 
cpu -> i_ c@ 189 <> if 8 bit or then 
cpu -> r c@ 24 <> if 9 bit or then 
cpu -> a_ c@ 102 <> cpu -> f_ c@ 251 <> or if 10 bit or then 
cpu -> b_ c@ 78 <> cpu -> c_ c@ 93 <> or if 11 bit or then 
cpu -> d_ c@ 89 <> cpu -> e_ c@ 171 <> or if 12 bit or then 
cpu -> h_ c@ 113 <> cpu -> l_ c@ 197 <> or if 13 bit or then 
cpu -> ix h@ 28331 <> if 14 bit or then 
cpu -> iy h@ 53165 <> if 15 bit or then 
cpu -> pc h@ 24425 <> if 16 bit or then 
cpu -> sp h@ 10572 <> if 17 bit or then 
cpu -> mem_ptr h@ 19101 <> if 18 bit or then 
24423 ram + c@ 221 <> if 19 bit or then 
24424 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4F 0003 : " 
9918 cpu -> pc h! 45547 cpu -> sp h! 
250 cpu -> a c! 108 cpu -> b c! 73 cpu -> c c! 140 cpu -> d c! 
72 cpu -> e c! 81 cpu -> f c! 118 cpu -> h c! 127 cpu -> l c! 
53 cpu -> i_ c! 98 cpu -> r c! 5258 cpu -> mem_ptr h! 
15524 cpu -> ix h! 9178 cpu -> iy h! 
24 cpu -> a_ c! 238 cpu -> f_ c! 120 cpu -> b_ c! 62 cpu -> c_ c! 
194 cpu -> d_ c! 84 cpu -> e_ c! 5 cpu -> h_ c! 108 cpu -> l_ c! 
221 ram 9918 + c! 79 ram 9919 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 250 <> if 0 bit or then 
cpu -> b c@ 108 <> if 1 bit or then 
cpu -> c c@ 250 <> if 2 bit or then 
cpu -> d c@ 140 <> if 3 bit or then 
cpu -> e c@ 72 <> if 4 bit or then 
cpu -> f c@ 81 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 81 h.2 [char] ] emit space then 
cpu -> h c@ 118 <> if 6 bit or then 
cpu -> l c@ 127 <> if 7 bit or then 
cpu -> i_ c@ 53 <> if 8 bit or then 
cpu -> r c@ 100 <> if 9 bit or then 
cpu -> a_ c@ 24 <> cpu -> f_ c@ 238 <> or if 10 bit or then 
cpu -> b_ c@ 120 <> cpu -> c_ c@ 62 <> or if 11 bit or then 
cpu -> d_ c@ 194 <> cpu -> e_ c@ 84 <> or if 12 bit or then 
cpu -> h_ c@ 5 <> cpu -> l_ c@ 108 <> or if 13 bit or then 
cpu -> ix h@ 15524 <> if 14 bit or then 
cpu -> iy h@ 9178 <> if 15 bit or then 
cpu -> pc h@ 9920 <> if 16 bit or then 
cpu -> sp h@ 45547 <> if 17 bit or then 
cpu -> mem_ptr h@ 5258 <> if 18 bit or then 
9918 ram + c@ 221 <> if 19 bit or then 
9919 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
." DD 4F 0004 : " 
29780 cpu -> pc h! 42937 cpu -> sp h! 
250 cpu -> a c! 163 cpu -> b c! 208 cpu -> c c! 250 cpu -> d c! 
80 cpu -> e c! 45 cpu -> f c! 30 cpu -> h c! 56 cpu -> l c! 
105 cpu -> i_ c! 72 cpu -> r c! 24501 cpu -> mem_ptr h! 
21117 cpu -> ix h! 44886 cpu -> iy h! 
38 cpu -> a_ c! 113 cpu -> f_ c! 213 cpu -> b_ c! 109 cpu -> c_ c! 
28 cpu -> d_ c! 243 cpu -> e_ c! 128 cpu -> h_ c! 39 cpu -> l_ c! 
221 ram 29780 + c! 79 ram 29781 + c! 
depth to dpt 
cpu -> step 
0 
cpu -> a c@ 250 <> if 0 bit or then 
cpu -> b c@ 163 <> if 1 bit or then 
cpu -> c c@ 250 <> if 2 bit or then 
cpu -> d c@ 250 <> if 3 bit or then 
cpu -> e c@ 80 <> if 4 bit or then 
cpu -> f c@ 45 <> if 5 bit or [char] [ emit cpu -> f c@ h.2 space 45 h.2 [char] ] emit space then 
cpu -> h c@ 30 <> if 6 bit or then 
cpu -> l c@ 56 <> if 7 bit or then 
cpu -> i_ c@ 105 <> if 8 bit or then 
cpu -> r c@ 74 <> if 9 bit or then 
cpu -> a_ c@ 38 <> cpu -> f_ c@ 113 <> or if 10 bit or then 
cpu -> b_ c@ 213 <> cpu -> c_ c@ 109 <> or if 11 bit or then 
cpu -> d_ c@ 28 <> cpu -> e_ c@ 243 <> or if 12 bit or then 
cpu -> h_ c@ 128 <> cpu -> l_ c@ 39 <> or if 13 bit or then 
cpu -> ix h@ 21117 <> if 14 bit or then 
cpu -> iy h@ 44886 <> if 15 bit or then 
cpu -> pc h@ 29782 <> if 16 bit or then 
cpu -> sp h@ 42937 <> if 17 bit or then 
cpu -> mem_ptr h@ 24501 <> if 18 bit or then 
29780 ram + c@ 221 <> if 19 bit or then 
29781 ram + c@ 79 <> if 19 bit or then 
depth dpt 1+ <> if 20 bit or then 
dup 0= if ." pass" drop  else ." fail:" 2 base ! . decimal then cr 
 depth . cr ; 
