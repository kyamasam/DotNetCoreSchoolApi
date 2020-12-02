using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Roster.Models;

namespace Roster.Features.School
{
    public class Create
    {
        public class SchoolResponseModel
        {
            public int SchoolId;
            public string Name { get; set; }
            public string City { get; set; }
            public string State { get; set; }
        }

        // command
        public class CreateSchoolCommand : IRequest<SchoolResponseModel>
        {
            //values in the request
            public string Name { get; set; }
            public string City { get; set; }
            public string State { get; set; }

            //<request, response>
            public class CreateSchoolCommandHandler : IRequestHandler<CreateSchoolCommand, SchoolResponseModel>
            {
                //logic implementation
                
                //context
                //dependency injection
                private readonly RosterDbContext _context;

                public CreateSchoolCommandHandler(RosterDbContext context)
                {
                    this._context = context;
                }
                
                
                public async Task<SchoolResponseModel> Handle(CreateSchoolCommand request, CancellationToken cancellationToken)
                {
                    // instantiate the model
                    var result = new Models.School
                    {
                        Name = request.Name,
                        City = request.City,
                        State = request.State
                    };
                    
                    //save to database

                    await _context.School.AddAsync(result);
                    await _context.SaveChangesAsync();
                    
                    return new SchoolResponseModel()
                    {
                        SchoolId = result.SchoolId,
                        City = result.City,
                        Name = result.Name,
                        State = result.State
                    };
                }
            }
        }
    }

    //values in the response
}