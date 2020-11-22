﻿using System.Threading.Tasks;
using SayWhat.MongoDAL.Users;

namespace SayWhat.Bll.Services
{
    public class UserService
    {
        private readonly UsersRepo _repository;
        public UserService(UsersRepo repository) => _repository = repository;
        
        public Task AddUserAsync(User user) => _repository.Add(user);
        
//        public async Task<User> GetUserByLoginOrNullAsync(string login, string password) => 
//            await _repository.GetUserByLoginOrNullAsync(login,password);
        
        public Task<User> GetUserByTelegramIdAsync(long telegramId) => 
            _repository.GetOrDefaultByTelegramId(telegramId);
    }
}