﻿using Domain.Common;
using MediatR;

namespace Application.Commands.MedicalConditionCommands
{
    public class CreateMedicalConditionCommand : IRequest<Result<Guid>>
    {
        public Guid PatientId { get; set; }

        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public required string CurrentStatus { get; set; }
        public Boolean IsGenetic { get; set; }
        public required string Recommendation { get; set; }


    }
}
