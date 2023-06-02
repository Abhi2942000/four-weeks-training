function introduce(person) {
    var firstName = person.firstName, lastName = person.lastName, age = person.age;
    console.log("".concat(firstName, " ").concat(lastName, " is ").concat(age, " years old."));
}
// Testing the introduce function
var person1 = {
    firstName: "Abhi",
    lastName: "Bhosale",
    age: 23,
};
var person2 = {
    firstName: "Sharvil",
    lastName: "Patil",
    age: 2,
};
introduce(person1); // Output: Alice Smith is 25 years old.
introduce(person2); // Output: Bob Johnson is 32 years old.
