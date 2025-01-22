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
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(new User());

            Assert.IsTrue(reservation.CanBeCancelledBy(adminUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsOwner_ReturnsTrue()
        {
            var ownerUser = new User { IsAdmin = false };
            var reservation = new Reservation(ownerUser);

            Assert.IsTrue(reservation.CanBeCancelledBy(ownerUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdminOrOwner_ReturnsFalse()
        {
            var ownerUser = new User { IsAdmin = false };
            var otherUser = new User { IsAdmin = false };
            var reservation = new Reservation(ownerUser);

            Assert.IsFalse(reservation.CanBeCancelledBy(otherUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_ReservationMadeByIsNull_ReturnsFalse()
        {
            var otherUser = new User { IsAdmin = false };
            var reservation = new Reservation(null); 

            Assert.IsFalse(reservation.CanBeCancelledBy(otherUser));
        }

        [TestMethod]
        public void CanBeCancelledBy_AdminWithMadeByNull_ReturnsTrue()
        {
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(null);

            Assert.IsTrue(reservation.CanBeCancelledBy(adminUser));
        }
    }
}
