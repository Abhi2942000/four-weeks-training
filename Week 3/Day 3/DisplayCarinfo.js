var Car = /** @class */ (function () {
    function Car(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    Car.prototype.displayCarInfo = function () {
        console.log("".concat(this.make, " ").concat(this.model, " (").concat(this.year, ")"));
    };
    return Car;
}());
// Creating a new instance of the Car class
var car = new Car("Toyota", "Camry", 2022);
// Calling the displayCarInfo method
car.displayCarInfo(); // Output: Toyota Camry (2022)
