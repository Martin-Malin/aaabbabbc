﻿var v=new List<string>();int i=0;while(v.Count<4){if(args[0][i]=='c')v.Add("c");else{v.Add(args[0].Substring(i,2));i++;}i++;}foreach(var k in"aa|ab|ba|bb|c".Split('|'))if(!v.Contains(k))Console.WriteLine(k);