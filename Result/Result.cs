namespace Result.Pattern;

public class Result<T> { 
    public bool IsSuccess { get; } 
    public bool IsFailure => !IsSuccess;   
    public T Value {get; }
    public string Message { get; }

    protected Result(bool isSuccess, T value, string message) 
    { 
        if (isSuccess && message != string.Empty) 
            throw new InvalidOperationException(); 
        if (!isSuccess && value != null) 
            throw new InvalidOperationException(); 

        IsSuccess = isSuccess; 
        Value = value; 
        Message = message; 
    }

    public static Result<T> Success(T value) 
    { 
        return new Result<T>(true, value, string.Empty); 
    }
    public static Result<T> Failure(string message) 
    { 
        return new Result<T>(false, default!, message); 
    }

    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure) 
    { 
        if (IsSuccess) 
            return onSuccess(Value); 
        else 
            return onFailure(Message); 
    }

    public Result<K> Map<K>(Func<T, K> func) 
    { 
        if (IsSuccess) 
            return Result<K>.Success(func(Value)); 
        else 
            return Result<K>.Failure(Message); 
    }
}