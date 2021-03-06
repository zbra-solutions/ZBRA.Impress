﻿
using System;
namespace ZBRA.Impress.Validation.Consistency
{
    public class ReturnParameterConsistencyException : Exception
    {
        private ValidationResult result;

        public ReturnParameterConsistencyException(ValidationResult result)
        {
            this.result = result;
        }

        public ValidationResult GetValidationResult()
        {
            return result;
        }
    }
}
