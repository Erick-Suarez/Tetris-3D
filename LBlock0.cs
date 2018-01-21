using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Unity.Collections.Generic;

public class LBlock0 {
    int x;
    int y;
    double i;
    double j;
    double k;
    int orientation;
    String blockType;
    String color;

    public LBlock0(int x, int y, int i, int j, int k, int orientation, String blockType){
        this.x = x;
        this.y = y;
        this.i = i;
        this.j = j;
        this.k = k;
        this.orientation = orientation;
        this.blockType = blockType;
        this.color = color;
    }

    private void spawn(){
      var mousePos = Input.mousePosition;
      mousePos.z = 1.0;
      var objectPos = Camera.current.ScreenToWorldPoint(mousePos);
      Instantiate(Lblock , 0,10,0, Quaternion.identity);
    }

    private void rotate(x,y) {
        this.GetComponent<map.cs>().rm2D_0_LBlock(x,y);
        if(this.GetComponent<map.cs>().canPlace_LBlock270(x,y)) {
            // Remove Current 3D Block and Replace with rotated version
        } else {
            this.GetComponent<map.cs>().rm2D_0_LBlock(x,y);
        }

    }
}
