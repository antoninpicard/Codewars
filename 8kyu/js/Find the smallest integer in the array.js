// Given an array of integers your solution should find the smallest integer.

// For example:

// Given [34, 15, 88, 2] your solution will return 2
// Given [34, -345, -1, 100] your solution will return -345
// You can assume, for the purpose of this kata, that the supplied array will not be empty.

class SmallestIntegerFinder {
    findSmallestInt(args) {
    var temp  ;
   
      for (var i=0;i<args.length;i++){
          if(args[i]<=args[0]){
              args[0]  = args[i];    
              temp = args[i];
          }
        }
      return temp;
    }
  }