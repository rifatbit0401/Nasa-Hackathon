using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.Model;

namespace Facebook.Repository
{
    class StatusRepository
    {
        private UserRepository userRepository;

        public StatusRepository()
        {
            userRepository
        }
        public bool AddStatus(User user, Status status)
        {
            user.Statuses.Add(status);

            return true;
        }

        public bool UpdateStatus(User user, String statusId, Status status)
        {
            return true;
        }

        public bool RemoveStatus(User user, String statusId)
        {
            return true;
        }

    }
}
