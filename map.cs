using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Unity.Collections.Generic;

int rows = 10;
int columns = 24;

int[,] MAP = new int[rows,columns];

/*============================================
   | = block
   c = pivot
   - = empty space
============================================*/

/*==================LBlock==================*/
/*===================================
---|----
---c----
---||---
===================================*/
void rm2D_0_LBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y+1] = 0;
  MAP[x+1,y-1] = 0;
}
void add2D_0_LBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y+1] = 1;
  MAP[x+1,y-1] = 1;
}
bool canPlace_LBlock0(int x,int y) {
  return(MAP[x,y] == 0 && MAP[x,y-1] == 0 && MAP[x,y+1] == 0 && MAP[x+1,y-1] == 0);
}

/*===================================
----|---
--|c|---
--------
===================================*/
void rm2D_90_LBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y+1] = 0;
}
void add2D_90_LBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y+1] = 1;
}
bool canPlace_LBlock90(int x,int y) {
  return(MAP[x,y] == 0 && MAP[x+1,y] == 0 && MAP[x-1,y] == 0 && MAP[x+1,y+1] == 0);
}

/*===================================
--||----
---c----
---|----
===================================*/
void rm2D_180_LBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y+1] = 0;
  MAP[x-1,y+1] = 0;
}
void add2D_180_LBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y+1] = 1;
  MAP[x-1,y+1] = 1;
}
bool canPlace_LBlock180(int x,int y) {
  return(MAP[x,y] == 0 && MAP[x,y-1] == 0 && MAP[x,y+1] == 0 && MAP[x-1,y+1] == 0);
}

/*===================================
-------
--|c|---
--|---
===================================*/
void rm2D_270_LBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x-1,y-1] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y] = 0;
}
void add2D_270_LBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x-1,y-1] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y] = 1;
}
bool canPlace_LBlock270(int x,int y) {
  return(MAP[x,y] == 0 && MAP[x-1,y-1] == 0 && MAP[x-1,y] == 0 && MAP[x+1,y] == 0);
}
/*=========================================*/
