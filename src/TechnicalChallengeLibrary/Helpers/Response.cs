using System;


namespace TechnicalChallengeLibrary.Helpers
{
    public class Response<T>
    {
		public T Entity { get; private set; }
		public bool Success { get; private set; }
		public string Description { get; private set; }
		public Exception Exception { get; private set; }
		public Response(bool succes, string description, T entity, Exception exception = null)
		{
			Entity = entity;
			Success = succes;
			Description = description;
			Exception = exception;
		}
	}
}
