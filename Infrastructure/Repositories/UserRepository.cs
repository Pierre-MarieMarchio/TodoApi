using System;
using TodoApi.Domain.Interfaces;
using TodoApi.Domain.Models;
using TodoApi.Infrastructure.Persistence.Context;
using TodoApi.Infrastructure.Commons;


namespace TodoApi.Infrastructure.Repositories;

public class UserRepository(DatabaseContext context) : BaseRepository<User>(context), IUserRepository
{
}
