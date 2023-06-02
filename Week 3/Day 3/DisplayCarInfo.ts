class Car {
    make: string;
    model: string;
    year: number;
  
    constructor(make: string, model: string, year: number) {
      this.make = make;
      this.model = model;
      this.year = year;
    }
  
    displayCarInfo(): void {
      console.log(`${this.make} ${this.model} (${this.year})`);
    }
  }
  
  // Creating a new instance of the Car class
  const car = new Car("Toyota", "Camry", 2022);
  
  // Calling the displayCarInfo method
  car.displayCarInfo(); // Output: Toyota Camry (2022)
  