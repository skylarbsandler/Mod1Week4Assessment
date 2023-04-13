namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";

            Assert.Equal(expected, andysBike.Summary());
        }

        [Fact]
        public void Confirm_Vechicle_AddsMileageCorrectly()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            andysBike.Drive();
            
            Assert.Equal(5, andysBike.MilesDriven);
        }

        [Fact]
        public void Confirm_Vehicle_PaintColor_GetsReassigned()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            andysBike.Paint("Red");
         
            Assert.Equal("Red", andysBike.Color);
        }
    }
}