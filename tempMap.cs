

//RLblock Start
/*===================================
---|----
---c----
--||---
===================================*/
void rm2D_0_RLBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y+1] = 0;
  MAP[x-1,y-1] = 0;
}
void add2D_0_RLBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y+1] = 1;
  MAP[x-1,y-1] = 1;
}

/*=================================
-------
--|c|---
----|---
===================================*/
void rm2D_90_RLBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y-1] = 0;
}
void add2D_90_RLBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y-1] = 1;
}

/*=================================
---||---
---c----
---|---
===================================*/
void rm2D_180_RLBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y+1] = 0;
  MAP[x+1,y+1] = 0;
}
void add2D_180_RLBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y+1] = 1;
  MAP[x+1,y+1] = 1;
}

/*=================================
--|----
--|c|--
-------
===================================*/
void rm2D_270_RLBlock(int x,int y){
  MAP[x-1,y+1] = 0;
  MAP[x-1,y] = 0;
  MAP[x,y+1] = 0;
  MAP[x+1,y] = 0;
}
void add2D_270_RLBlock(int x,int y){
  MAP[x-1,y+1] = 1;
  MAP[x-1,y] = 1;
  MAP[x,y+1] = 1;
  MAP[x+1,y] = 1;
}
/*=========================================*/

//LineBlock
/*===================================
--------
--|c||--
--------
===================================*/
void rm2D_0_LineBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x+2,y] = 0;
}
void add2D_0_LineBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x+2,y] = 1;
}

/*=================================
---|---
---|---
---c---
---|---
===================================*/
void rm2D_90_LineBlock(int x,int y){
  MAP[x,y+2] = 0;
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
}
void add2D_90_LineBlock(int x,int y){
  MAP[x,y+2] = 1;
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
}
/*=================================
--------
-||c|---
--------
===================================*/
void rm2D_180_LineBlock(int x,int y){
  MAP[x+1,y] = 0;
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x-2,y] = 0;
}
void add2D_180_LineBlock(int x,int y){
  MAP[x+1,y] = 1;
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x-2,y] = 1;
}

/*=================================
---|---
---c--
---|---
---|---
===================================*/
void rm2D_270_LineBlock(int x,int y){
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y-2] = 0;
}
void add2D_270_LineBlock(int x,int y){
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y-2] = 1;
}
/*=========================================*/

//SquareBlock
/*=================================
---||--
---c|--
-------
===================================*/
void rm2D_SquareBlock(int x,int y){
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y-2] = 0;
}
void add2D_SquareLineBlock(int x,int y){
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y-2] = 1;
}
/*=========================================*/

//TODO: The Rest of these ...
//SBlock
/*===================================
---||---
--|c----
--------
===================================*/
void rm2D_0_SBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x+2,y] = 0;
}
void add2D_0_SBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x+2,y] = 1;
}

/*=================================
---|---
---|---
---c---
---|---
===================================*/
void rm2D_90_SBlock(int x,int y){
  MAP[x,y+2] = 0;
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
}
void add2D_90_SBlock(int x,int y){
  MAP[x,y+2] = 1;
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
}
/*=================================
--------
-||c|---
--------
===================================*/
void rm2D_180_SBlock(int x,int y){
  MAP[x+1,y] = 0;
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x-2,y] = 0;
}
void add2D_180_SBlock(int x,int y){
  MAP[x+1,y] = 1;
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x-2,y] = 1;
}

/*=================================
---|---
---c--
---|---
---|---
===================================*/
void rm2D_270_SBlock(int x,int y){
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y-2] = 0;
}
void add2D_270_SBlock(int x,int y){
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y-2] = 1;
}
/*=========================================*/

//RSBlock
/*===================================
--||---
---c|---
--------
===================================*/
void rm2D_0_RSBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x+2,y] = 0;
}
void add2D_0_RSBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x+2,y] = 1;
}

/*=================================
---|---
---|---
---c---
---|---
===================================*/
void rm2D_90_RSBlock(int x,int y){
  MAP[x,y+2] = 0;
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
}
void add2D_90_RSBlock(int x,int y){
  MAP[x,y+2] = 1;
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
}
/*=================================
--------
-||c|---
--------
===================================*/
void rm2D_180_RSBlock(int x,int y){
  MAP[x+1,y] = 0;
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x-2,y] = 0;
}
void add2D_180_RSBlock(int x,int y){
  MAP[x+1,y] = 1;
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x-2,y] = 1;
}

/*=================================
---|---
---c--
---|---
---|---
===================================*/
void rm2D_270_RSBlock(int x,int y){
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y-2] = 0;
}
void add2D_270_RSBlock(int x,int y){
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y-2] = 1;
}
/*=========================================*/

//TBlock
/*===================================
--|c|---
---|----
--------
===================================*/
void rm2D_0_TBlock(int x,int y){
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x+1,y] = 0;
  MAP[x+2,y] = 0;
}
void add2D_0_TBlock(int x,int y){
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x+1,y] = 1;
  MAP[x+2,y] = 1;
}

/*=================================
---|---
---|---
---c---
---|---
===================================*/
void rm2D_90_TBlock(int x,int y){
  MAP[x,y+2] = 0;
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
}
void add2D_90_TBlock(int x,int y){
  MAP[x,y+2] = 1;
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
}
/*=================================
--------
-||c|---
--------
===================================*/
void rm2D_180_TBlock(int x,int y){
  MAP[x+1,y] = 0;
  MAP[x,y] = 0;
  MAP[x-1,y] = 0;
  MAP[x-2,y] = 0;
}
void add2D_180_TBlock(int x,int y){
  MAP[x+1,y] = 1;
  MAP[x,y] = 1;
  MAP[x-1,y] = 1;
  MAP[x-2,y] = 1;
}

/*=================================
---|---
---c--
---|---
---|---
===================================*/
void rm2D_270_TBlock(int x,int y){
  MAP[x,y+1] = 0;
  MAP[x,y] = 0;
  MAP[x,y-1] = 0;
  MAP[x,y-2] = 0;
}
void add2D_270_LBlock(int x,int y){
  MAP[x,y+1] = 1;
  MAP[x,y] = 1;
  MAP[x,y-1] = 1;
  MAP[x,y-2] = 1;
}
/*=========================================*/
