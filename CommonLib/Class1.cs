﻿namespace CommonLib;

public record Input(string A, int B, uint C);
public record Output(string A);

public class CommonApi
{
    public static Output MyApi(Input input)
    {
        return new(A: input.A);
    }
}
