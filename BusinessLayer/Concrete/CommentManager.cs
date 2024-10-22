﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetlist()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x=>x.DestinationID== id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
