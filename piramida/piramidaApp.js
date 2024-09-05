function printPyramid(n) {
    for (let i = 1; i < n; i++) {
      let space = " ".repeat(n - i);
      let stars = "*".repeat(2*i-1);
      console.log(space + stars);
    }
  }
  
  printPyramid(15);