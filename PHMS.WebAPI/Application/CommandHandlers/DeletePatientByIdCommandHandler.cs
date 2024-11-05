﻿using Application.Commands;
using Domain.Common;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class DeletePatientByIdCommandHandler : IRequestHandler<DeletePatientByIdCommand, Result<Unit>>
    {
        private readonly IPatientRepository repository;

        public DeletePatientByIdCommandHandler(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Result<Unit>> Handle(DeletePatientByIdCommand request, CancellationToken cancellationToken)
        {
            var patient = await repository.GetByIdAsync(request.Id);
            if (patient == null)
            {
                return Result<Unit>.Failure("Patient not found");
            }
            await repository.DeleteAsync(request.Id);
            return Result<Unit>.Success(Unit.Value);
        }
    }
}