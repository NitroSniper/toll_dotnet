namespace where_it_begins;

abstract class Vehicle
{
    int registration;
    int manufacturer;
    
    Vehicle(int registration, int manufacturer) {
        this.registration = registration;
        this.manufacturer = manufacturer;
    }
}
