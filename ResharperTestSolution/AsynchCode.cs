namespace ResharperTestSolution
{
    internal partial class User
    {
        public int Id { get; set; }
    }

    internal class AsynchCode
    {
        private static async Task<User> GetUserAsync(int userId)
        {
            // Code omitted:
            //
            // Given a user Id {userId}, retrieves a User object corresponding
            // to the entry in the database with {userId} as its Id.

            return await Task.FromResult(new User() { Id = userId });
        }

        private static async Task<IEnumerable<User>> GetUsersAsync(IEnumerable<int> userIds)
        {
            var getUserTasks = GetUserTasks();

            return await Task.WhenAll(getUserTasks);

            List<Task<User>> GetUserTasks()
            {
                var tasks = new List<Task<User>>();
                foreach (int userId in userIds)
                {
                    tasks.Add(GetUserAsync(userId));
                }

                return tasks;
            }
        }
        private static async Task<User[]> GetUsersAsyncByLINQ(IEnumerable<int> userIds)
        {
            var getUserTasks = userIds.Select(id => GetUserAsync(id)).ToArray();
            return await Task.WhenAll(getUserTasks);
        }
    }
}
