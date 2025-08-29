const LinkedList = require('./Linked-List')

class LinkedListStack{
    constructor(){
        this.list = new LinkedList();
    }

    isEmpty(){
        return this.list.isEmpty();
    }

    getSize(){
        return this.list.getSize();
    }

    push(value){
        this.list.prepend(value);
    }

    pop(){
        return this.list.removeFromFront();
    }

    peek(){
        return this.list.head.value
    }

    print(){
        return this.list.print();
    }
}

const stack = new LinkedListStack();

console.log(stack.isEmpty());

stack.push(10);
stack.push(20);
stack.push(30);
stack.push(40);

stack.print();


console.log(stack.getSize());
console.log(stack.isEmpty());
console.log(stack.peek());
stack.pop();


stack.print();