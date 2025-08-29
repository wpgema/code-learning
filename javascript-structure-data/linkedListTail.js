class Node{
    constructor(value){
        this.value = value;
        this.next = null;
    }
}

class LinkedList{
    constructor(){
        this.head = null;
        this.tail = null;
        this.size = 0;
    }

    isEmpty(){
        return this.size === 0;
    }

    getSize(){
        return this.size;
    }

    print(){
        if(this.isEmpty()){                                                 
            console.log(`List is empty`);
        } else {
            let curr = this.head;
            let listValues = "";
            while(curr){
                listValues += ` ${curr.value}`;
                curr = curr.next;
            }
            console.log(listValues)
        }
    }

    prepend(value){
        const node = new Node(value);
        if(this.isEmpty()){
            this.head = node;
            this.tail = node;
        } else {
            node.next = this.head;
            this.head = node;
        }
        this.size++;
    }

    append(value){
        const node = new Node(value);
        if(this.isEmpty()){
            this.head = node;
            this.tail = node;
        } else {
            this.tail.next = node;
            this.tail = node;
        }
        this.size++;
    }

    removeFromFront(){
        if(this.isEmpty()){
            return null;
        }
        const values = this.head.value;
        this.head = this.head.next;
        this.size--;
        return values;
    }

    removeFromEnd(){
        if(this.isEmpty()){
            return null;
        }
        const values = this.tail.value;
        if(this.size === 1){
            this.head = null;
            this.tail = null;
        } else {
            let prev = this.head;
            if(prev.next !== this.tail){
                prev = prev.next;
            }
            prev.next = null;
            this.tail = prev;
        }
        this.size--;
        return values
    }
}

const list = new LinkedList();
// console.log(`list is empty ? ${list.isEmpty()}`)
// console.log(`list size ? ${list.getSize()}`)
// list.print();

// list.prepend(3);
// list.prepend(2);
// list.prepend(1);
// list.prepend(0);
// console.log(`list size ? ${list.getSize()}`)
// list.print();

// list.prepend(3);
// list.prepend(2);
// list.append(1);
// list.prepend(0);
// list.print();
// console.log(`list size ? ${list.getSize()}`)
// console.log(list.removeFromFront());
// list.print();

// console.log(list.removeFromEnd());

list.append(10);
list.append(20);
list.append(30);
list.append(40);
list.print();