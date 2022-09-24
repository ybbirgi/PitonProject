using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Constants;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        EfUserDao userDao;

        public UserManager(EfUserDao userDao)
        {
            this.userDao = userDao;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);

            this.userDao.add(user);

            return new SuccessResult(Messages.GlobalMessages.DATA_ADDED_SUCCESSFULLY);
        }
        [SecuredOperation("admin")]
        public IDataResult<List<User>> getAll()
        {
            return new SuccessDataResult<List<User>>(this.userDao.getAll());
        }
        [SecuredOperation("admin")]
        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User> (this.userDao.get(u => u.Email == email));
        }
        [SecuredOperation("admin")]
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            throw new NotImplementedException();
        }
    }
}
