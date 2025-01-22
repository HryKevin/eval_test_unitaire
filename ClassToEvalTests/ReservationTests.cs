using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassToEval;

namespace ClassToEvalTests
{
    [TestClass]
    public class ReservationTests
    {

        //[TestMethod]
        //public class Reservation_WithMadeBy_ReturnString()
        //{
        //    Reservation _reservation = new Reservation(new User);
        //}

        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(new User());

            var result = reservation.CanBeCancelledBy(adminUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsOwner_ReturnsTrue()
        {
            var ownerUser = new User { IsAdmin = false };
            var reservation = new Reservation(ownerUser);

            var result = reservation.CanBeCancelledBy(ownerUser);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminOrOwner_ReturnsFalse()
        {
            var ownerUser = new User { IsAdmin = false };
            var otherUser = new User { IsAdmin = false };
            var reservation = new Reservation(ownerUser);

            var result = reservation.CanBeCancelledBy(otherUser);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AdminWithMadeByNull_ReturnsTrue()
        {
            // Arrange
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(null); 

            // Act
            var result = reservation.CanBeCancelledBy(adminUser);

            // Assert
            Assert.IsTrue(result, "An admin should always be able to cancel a reservation, even if MadeBy is null.");
        }
    }
}
