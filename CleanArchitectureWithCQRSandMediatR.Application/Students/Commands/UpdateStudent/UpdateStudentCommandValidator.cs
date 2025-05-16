using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediatR.Application.Students.Commands.UpdateStudent
{
    public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
    {
        public UpdateStudentCommandValidator()
        {
            RuleFor(v => v.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MaximumLength(100).WithMessage("First Name must not exceed 100 characters.");

            RuleFor(v => v.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MaximumLength(100).WithMessage("Last Name must not exceed 100 characters.");

            RuleFor(v => v.Gender)
                .NotEmpty().WithMessage("Gender is required.")
                .Must(g => g == "Male" || g == "Female" || g == "Other")
                .WithMessage("Gender must be Male, Female, or Other.");

            RuleFor(v => v.DateOfBirth)
                .NotEmpty().WithMessage("Date of Birth is required.")
                .LessThan(DateTime.Today).WithMessage("Date of Birth must be in the past.");

            RuleFor(v => v.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(150).WithMessage("Email must not exceed 150 characters.");

            RuleFor(v => v.PhoneNumber)
                .NotEmpty().WithMessage("Phone Number is required.")
                .Length(10).WithMessage("Phone Number must be exactly 10 digits.")
                .Matches(@"^\d{10}$").WithMessage("Phone Number must contain only digits.");

            RuleFor(v => v.Address)
                .NotEmpty().WithMessage("Address is required.")
                .MaximumLength(250).WithMessage("Address must not exceed 250 characters.");

            RuleFor(v => v.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(100).WithMessage("City must not exceed 100 characters.");

            RuleFor(v => v.State)
                .NotEmpty().WithMessage("State is required.")
                .MaximumLength(100).WithMessage("State must not exceed 100 characters.");

            RuleFor(v => v.PostalCode)
                .NotEmpty().WithMessage("Postal Code is required.")
                .Matches(@"^\d{4,8}$").WithMessage("Postal Code must be between 4 and 10 digits.");

            RuleFor(v => v.Country)
                .NotEmpty().WithMessage("Country is required.")
                .MaximumLength(100).WithMessage("Country must not exceed 100 characters.");

            RuleFor(v => v.GuardianName)
                .NotEmpty().WithMessage("Guardian Name is required.")
                .MaximumLength(100).WithMessage("Guardian Name must not exceed 100 characters.");

            RuleFor(v => v.GuardianPhone)
                .NotEmpty().WithMessage("Guardian Phone is required.")
                .Length(10).WithMessage("Guardian Phone must be exactly 10 digits.")
                .Matches(@"^\d{10}$").WithMessage("Guardian Phone must contain only digits.");

            RuleFor(v => v.GuardianEmail)
                .NotEmpty().WithMessage("Guardian Email is required.")
                .EmailAddress().WithMessage("Invalid guardian email format.")
                .MaximumLength(150).WithMessage("Guardian Email must not exceed 150 characters.");

            RuleFor(v => v.RelationshipToStudent)
                .NotEmpty().WithMessage("Relationship to Student is required.")
                .MaximumLength(50).WithMessage("Relationship must not exceed 50 characters.");

            RuleFor(v => v.IsActive)
                .NotNull().WithMessage("IsActive must be specified.");

            RuleFor(v => v.UpdatedAt)
                .LessThanOrEqualTo(DateTime.UtcNow).When(v => v.UpdatedAt.HasValue)
                .WithMessage("UpdatedAt must not be in the future.");
        }
    }
}
