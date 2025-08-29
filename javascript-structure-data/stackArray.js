// STACK OVERVIEW
// struktur data stack ini berprinsip last In First Out (LIFO)
// dimana elemen yang terakhir masuk adalah elemen yang pertama keluar
class Stack {
  constructor() {
    this.items = [];
  }

  push(element) {
    this.items.push(element);
  }

  pop() {
    return this.items.pop();
  }

  peek() {
    return this.items[this.items.length - 1];
  }

  isEmpty() {
    return this.items.length === 0;
  }

  size() {
    return this.items.length;
  }

  print() {
    console.log(this.items.toString());
  }
}
  
  const stack = new Stack();
  console.log(stack.isEmpty());
  stack.push(20);
  stack.push(10);
  stack.push(30);
  console.log(stack.size());
  stack.print();
  console.log(stack.pop());
  console.log(stack.peek());
  stack.print();
  
  class StackMySelf {
    constructor(){
      this.items = [];
    }
  
    push(element){
      this.items.push(element)
    }
  
    pop(){
      return this.items.pop()
    }
  
    size(){
      return this.items.length;
    }
  
    peek(){
      return this.items[this.items.length - 1];
    }
  
    isEmpty(){
      return this.items.length === 0;
    }
  
    print(){
      for(item of this.items){
        console.log(item)
      }
    }
  
  }
  