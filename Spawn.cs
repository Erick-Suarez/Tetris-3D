using System;
using System.Collections.Generic;
using System.Collections.Generic;
using Unity.Collections.Generic;

void Spawn() {
    bool grounded == true;

    while(grounded = true) {
        Random rnd = new Random();
        int spawnGroup = rnd.Next(1,8);
        switch(spawnGroup) {
          case 1:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 2:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 3:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 4:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 5:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 6:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;
          case 7:
              //TODO: Turn of pointer ctrl for past block
              LBlock0 tempLBlock = new LBlock();
              tempLBlock.spawn();
              //TODO: pointer on for new block
              grounded = false;        }
    }
}
