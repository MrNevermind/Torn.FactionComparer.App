/***********************************************************************
  This project provides a C# interface to the Torn.com API.
  Copyright (C) 2020  TornCityPro
  
  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.
  
  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.
  
  You should have received a copy of the GNU General Public License
  along with this program.  If not, see <http://www.gnu.org/licenses/>.
************************************************************************/

using System;
using System.Runtime.Serialization;
using Torn.FactionComparer.App.Contracts.CommonData;

namespace Torn.FactionComparer.App.Contracts.Exceptions
{
    /// <summary>
    ///     Represents error code 0
    /// </summary>
    [Serializable]
    public class UnknownException : ApiException
    {
        public UnknownException(TornExceptionInfo ex) : base(ex)
        {
        }

        public UnknownException()
        {
        }

        public UnknownException(string message) : base(message)
        {
        }

        public UnknownException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 1
    /// </summary>
    [Serializable]
    public class EmptyApiKeyException : ApiException
    {
        public EmptyApiKeyException(TornExceptionInfo ex) : base(ex)
        {
        }

        public EmptyApiKeyException()
        {
        }

        public EmptyApiKeyException(string message) : base(message)
        {
        }

        public EmptyApiKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyApiKeyException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 2
    /// </summary>
    [Serializable]
    public class IncorrectApiKeyException : ApiException
    {
        public IncorrectApiKeyException(TornExceptionInfo ex) : base(ex)
        {
        }

        public IncorrectApiKeyException()
        {
        }

        public IncorrectApiKeyException(string message) : base(message)
        {
        }

        public IncorrectApiKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectApiKeyException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 3
    /// </summary>
    [Serializable]
    public class WrongTypeException : ApiException
    {
        public WrongTypeException(TornExceptionInfo ex) : base(ex)
        {
        }

        public WrongTypeException()
        {
        }

        public WrongTypeException(string message) : base(message)
        {
        }

        public WrongTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongTypeException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 4
    /// </summary>
    [Serializable]
    public class WrongFieldException : ApiException
    {
        public WrongFieldException(TornExceptionInfo ex) : base(ex)
        {
        }

        public WrongFieldException()
        {
        }

        public WrongFieldException(string message) : base(message)
        {
        }

        public WrongFieldException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongFieldException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 5
    /// </summary>
    [Serializable]
    public class TooManyRequestsException : ApiException
    {
        public TooManyRequestsException(TornExceptionInfo ex) : base(ex)
        {
        }

        public TooManyRequestsException()
        {
        }

        public TooManyRequestsException(string message) : base(message)
        {
        }

        public TooManyRequestsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManyRequestsException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 6
    /// </summary>
    [Serializable]
    public class IncorrectIdException : ApiException
    {
        public IncorrectIdException(TornExceptionInfo ex) : base(ex)
        {
        }

        public IncorrectIdException()
        {
        }

        public IncorrectIdException(string message) : base(message)
        {
        }

        public IncorrectIdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectIdException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 7
    /// </summary>
    [Serializable]
    public class IncorrectIdEntityRelationException : ApiException
    {
        public IncorrectIdEntityRelationException(TornExceptionInfo ex) : base(ex)
        {
        }

        public IncorrectIdEntityRelationException()
        {
        }

        public IncorrectIdEntityRelationException(string message) : base(message)
        {
        }

        public IncorrectIdEntityRelationException(string message, Exception innerException) : base(message,
            innerException)
        {
        }

        protected IncorrectIdEntityRelationException(SerializationInfo serializationInfo,
            StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 8
    /// </summary>
    [Serializable]
    public class BlockedIpException : ApiException
    {
        public BlockedIpException(TornExceptionInfo ex) : base(ex)
        {
        }

        public BlockedIpException()
        {
        }

        public BlockedIpException(string message) : base(message)
        {
        }

        public BlockedIpException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BlockedIpException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 9
    /// </summary>
    [Serializable]
    public class ApiDisabledException : ApiException
    {
        public ApiDisabledException(TornExceptionInfo ex) : base(ex)
        {
        }

        public ApiDisabledException()
        {
        }

        public ApiDisabledException(string message) : base(message)
        {
        }

        public ApiDisabledException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiDisabledException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 10
    /// </summary>
    [Serializable]
    public class PlayerBannedException : ApiException
    {
        public PlayerBannedException(TornExceptionInfo ex) : base(ex)
        {
        }

        public PlayerBannedException()
        {
        }

        public PlayerBannedException(string message) : base(message)
        {
        }

        public PlayerBannedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PlayerBannedException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 11
    /// </summary>
    [Serializable]
    public class ApiKeyChangeException : ApiException
    {
        public ApiKeyChangeException(TornExceptionInfo ex) : base(ex)
        {
        }

        public ApiKeyChangeException()
        {
        }

        public ApiKeyChangeException(string message) : base(message)
        {
        }

        public ApiKeyChangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiKeyChangeException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 12
    /// </summary>
    [Serializable]
    public class ApiKeyReadException : ApiException
    {
        public ApiKeyReadException(TornExceptionInfo ex) : base(ex)
        {
        }

        public ApiKeyReadException()
        {
        }

        public ApiKeyReadException(string message) : base(message)
        {
        }

        public ApiKeyReadException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiKeyReadException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 13
    /// </summary>
    [Serializable]
    public class ApiKeyDisabledException : ApiException
    {
        public ApiKeyDisabledException(TornExceptionInfo ex) : base(ex)
        {
        }

        public ApiKeyDisabledException()
        {
        }

        public ApiKeyDisabledException(string message) : base(message)
        {
        }

        public ApiKeyDisabledException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiKeyDisabledException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 14
    /// </summary>
    [Serializable]
    public class DailyReadLimitReachedException : ApiException
    {
        public DailyReadLimitReachedException(TornExceptionInfo ex) : base(ex)
        {
        }

        public DailyReadLimitReachedException()
        {
        }

        public DailyReadLimitReachedException(string message) : base(message)
        {
        }

        public DailyReadLimitReachedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DailyReadLimitReachedException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 15
    /// </summary>
    [Serializable]
    public class TemporaryErrorException : ApiException
    {
        public TemporaryErrorException(TornExceptionInfo ex) : base(ex)
        {
        }

        public TemporaryErrorException()
        {
        }

        public TemporaryErrorException(string message) : base(message)
        {
        }

        public TemporaryErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TemporaryErrorException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    ///     Represents error code 16
    /// </summary>
    [Serializable]
    public class AccessLevelException : ApiException
    {
        public AccessLevelException(TornExceptionInfo ex) : base(ex)
        {
        }

        public AccessLevelException()
        {
        }

        public AccessLevelException(string message) : base(message)
        {
        }

        public AccessLevelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccessLevelException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            throw new NotImplementedException();
        }
    }
}