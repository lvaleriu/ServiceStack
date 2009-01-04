using ServiceStack.LogicFacade;

namespace ServiceStack.ServiceInterface
{
	public interface IService
	{
		object Execute(ICallContext context);
	}
}