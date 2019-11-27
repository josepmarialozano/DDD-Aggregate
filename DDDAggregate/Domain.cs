using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDAggregate {
    public class Domain {
        private Car car;
        public Car GetCar() {
            car = new Car {
                Motor = new Motor {
                    Block = "Block"
                },
                Wheels = new Wheel[] {
                    new Wheel {
                        Tyre = "1",
                        IsFlat = false
                    },
                    new Wheel {
                        Tyre = "2",
                        IsFlat = false
                    },
                    new Wheel {
                        Tyre = "3",
                        IsFlat = false
                    },
                    new Wheel {
                        Tyre = "4",
                        IsFlat = false
                    }
                }
            };
            return car;
        }

        public void flatTyre(int tyreNumber) {
            Wheel tyre = car.Wheels[tyreNumber];
            tyre.IsFlat = true;
        }

    }
}
