namespace OpenIdentity.Extentions
{
	public static class ResponseExtention
	{
		public static ObjectResult CreateResponse(this Exception ex)
		{
			var response = new ErrorResponse();
			response.Message = ex.Message;

			var atException = ex;
			while (atException != null)
			{
				response.ExceptionErrors.Add(atException.ToString());
				atException = atException.InnerException;
			}


			var result = new ObjectResult(response);
			if (ex is UserExistsException)
			{
				result.StatusCode = 409;
			}
			else if(ex is UnauthorizedAccessException)
			{
				result.StatusCode = 401;
			}
			else
			{
				result.StatusCode = 500;
			}
			return result;
		}
	}
}
