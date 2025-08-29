// QUEUE OPTIMISED
// struktur data queue ini berprinsip First In First Out (FIFO)
// dimana elemen yang pertama masuk adalah elemen yang pertama keluar
class Queue{
    constructor(){
        this.items = {};
        this.rear = 0;
        this.front = 0;
    }
    enqueue(element){
        this.items[this.rear] = element;
        this.rear++
    }
    dequeue(){
        const item = this.items[this.front];
        delete this.items[this.front];
        this.front++;
        return item;
    }
    isEmpty(){
        return this.rear - this.front == 0;
    }
    peek(){
        return this.items[this.front];
    }
    size(){
        return this.rear - this.front;
    }
    print(){
        console.log(this.items);
    }
}

const ama = new Queue();
console.log(ama.isEmpty());

ama.enqueue(10);
ama.enqueue(20)
ama.enqueue(30)

console.log(ama.print());
console.log(ama.size());

console.log(ama.dequeue());

console.log(ama.peek());

class QueueMySelf {
    constructor(){
        this.items = {};
        this.rear = 0;
        this.front = 0;
    }

    enqueue(element){
        this.items[this.rear] = element;
        this.rear++;
    }

    dequeue(){
        const item = this.items[this.front];
        delete this.items[this.front];
        this.front++;
        return item;
    }

    size(){
        return this.rear - this.front;
    }

    peek(){
        return this.items[this.front]
    }

    isEmpty(){
        return this.rear - this.front == 0;
    }

    print(){
        console.log(this.items)
    }
}