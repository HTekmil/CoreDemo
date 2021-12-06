using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _messagel2Dal;

        public Message2Manager(IMessage2Dal messagel2Dal)
        {
            _messagel2Dal = messagel2Dal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messagel2Dal.GetListWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _messagel2Dal.GetListAll();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _messagel2Dal.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
