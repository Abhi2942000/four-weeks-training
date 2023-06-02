interface Person {
    firstName: string;
    lastName: string;
    age: number;
  }
  
  function introduce(person: Person): void {
    const { firstName, lastName, age } = person;
    console.log(`${firstName} ${lastName} is ${age} years old.`);
  }
  
  // Testing the introduce function
  const person1: Person = {
    firstName: "Abhi",
    lastName: "Bhosale",
    age: 23,
  };
  
  const person2: Person = {
    firstName: "Sharvil",
    lastName: "Patil",
    age: 2,
  };
  
  introduce(person1); 
  introduce(person2); 
  