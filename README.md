https://codegolf.stackexchange.com/questions/266561/aaabbabbc

# aaabbabbc

One element of the list `aa, ab, ba, bb, c` has been removed, and the remainder shuffled and joined with no separator. Find the missing element.

For example, if the input was `aaabbac`, this is made by concatenating `aa ab ba c`, so the output would be `bb`.

## Rules

 - Standard I/O rules apply.
 - You must take input as a string (or equivalent in your language), and you must use the characters `abc` as in the question; you cannot substitute them for others.
 - This is code golf, shortest code in bytes wins.

## Test cases

```
cbbbaab  -> aa
bbbaabc  -> aa
cabbabb  -> aa
baaacbb  -> ab
bbcaaba  -> ab
caababb  -> ab
bbcabaa  -> ba
abcaabb  -> ba
abcbbaa  -> ba
bacaaab  -> bb
aacabba  -> bb
caaabba  -> bb
bbabaaba -> c
aaabbabb -> c
abaabbba -> c
```
