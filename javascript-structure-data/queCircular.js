class CircularQueue{
    constructor(capacity){
        this.items = new Array(capacity);
        this.capacity = capacity
        this.front = -1;
        this.rear = -1;
        this.currentLength = 0;
    }

    isFull(){
        return this.capacity === this.currentLength;
    }

    isEmpty(){
        return this.currentLength === 0;
    }

    enqueue(element){
        if(!this.isFull()){
            this.rear = (this.rear + 1) % this.capacity;
            this.items[this.rear] = element;
            this.currentLength += 1;
            if(this.front === -1){
                this.front = this.rear
            }
        }
    }


    dequeue(){
        if(this.isEmpty()){
            return null;
        }

        const item = this.items[this.front];
        this.items[this.front] = null;
        this.front = (this.front + 1) % this.capacity;
        this.currentLength -= 1;
        if(this.isEmpty()){
            this.front = -1;
            this.rear = -1;
        }
        return item;
    }

    rest(){
        return this.capacity - this.currentLength;
    }

    peek(){
        return this.items[this.front]
    }

    print(){
        if(this.isEmpty()){
            console.log("Queue is empty");
        } else {
            let i;
            let str = "";
            for(i = this.front; i !== this.rear; i = (i + 1) % this.capacity){
                str += this.items[i] + " - ";
            }
            str += this.items[i];
            console.log(str);
        }
    }
}

const queue = new CircularQueue(6);

// console.log(queue.isEmpty());

queue.enqueue(10);
queue.enqueue(20);
queue.enqueue(30);
queue.enqueue(40);
queue.enqueue(50);
queue.enqueue(60);
console.log(queue.dequeue());
queue.enqueue(70);

// console.log(queue.isFull());

queue.print();

// console.log(queue.dequeue());
// console.log(queue.peek());

// console.log(queue.print());
// console.log(queue.rest());

class CircularQueueMySelf {
    constructor(capacity){
        this.items = new Array(capacity);
        this.capacity = capacity;
        this.front = -1;
        this.rear = -1;
        this.currentLength = 0;
    }

    isEmpty(){
        return this.currentLength === 0;
    }

    isFull(){
        return this.capacity === this.currentLength;
    }

    enqueue(element){
        if(!this.isFull()){
            this.rear = (this.rear + 1) % this.capacity;
            this.items[this.rear] = element;
            this.currentLength += 1;
            if(this.front === -1){
                this.front = this.rear;
            }
        }
    }

    dequeue(){
        if(this.isEmpty()){
            return null;
        }
        const item = this.items[this.front];
        this.items[this.front] = null;
        this.front = (this.front + 1) % this.capacity
        this.currentLength -= 1;
        if(this.isEmpty()){
            this.rear = -1;
            this.front = -1;
        }
        return item
    }

    size(){
        return this.currentLength;
    }

    capacity(){
        return this.capacity;
    }

    rest(){
        return this.currentLength - this.capacity;
    }

    print(){
        if(this.isEmpty){
            return "Que is empty ?"
        }
        let str = '';
        for(let i = this.front; i !== this.rear; i = (i  + 1) % this.capacity ){
            str += this.items[i];
        }
        str += this.items[i]
        console.log(str)
    }

}