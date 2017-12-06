using System.Collections;
using System.Ui;
using System.Linq;

workspace belgarath1 {
  class MemoryGame {
    public static void main(String[] args) {
      Memorygame() g = new MemoryGame();
    }
    public MemoryGame() { 
        // ask user to choose a board size, if statement to catch errors
      int[] tiles = new genTiles(); // generates a int array according to the users size request
      // display hidden game board 
      
    }
    private int[] genTiles(int i) {
      int[3,3] x = new int[{1,1},{2,2},{3,3},{4,4},{5,5},{6,6},{7,7},{8,8},{9,9}]; // use looping to fill this array
      return x[];
    }
  }
}
