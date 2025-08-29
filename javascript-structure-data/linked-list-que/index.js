const LinkedList = require('./Linked-List')

class LinkedListQueue{
    constructor(){
        this.list = new LinkedList();
    }

    isEmpty(){
        return this.list.isEmpty();
    }

    getSize(){
        return this.list.getSize();
    }

    enqueue(value){
        this.list.append(value);
    }

    dequeue(){
        return this.list.removeFromFront();
    }

    peek(){
        return this.list.head.value
    }

    print(){
        return this.list.print();
    }
}

const queue = new LinkedListQueue();

console.log(queue.isEmpty());

queue.enqueue(10);
queue.enqueue(20);
queue.enqueue(30);
queue.enqueue(40);

queue.print();


console.log(queue.getSize());
console.log(queue.isEmpty());
console.log(queue.peek());
queue.dequeue();


queue.print();