# csv-query-csharp

## Dependencies

- CommandLineParser

## .Net Version Support

`.Net>=v4.5`

## Project Location 

```src\CSVQueryCSharp```

## Test Location

```test\CSVQueryCSharp.Test```

## csv-query-csharp

* You need to open the project location then run the below command

`$ dotnet run src/search.js <FilePath> <ColumnIndex> <SearchValue>`

* example:
  
`$ dotnet run src/search.js C:\Users\Users\Project\file.csv 2 Albertos`

### CSV Format

```
1,Rossi,Fabio,01/06/1990;
2,Gialli,Alessandro,02/07/1989;
3,Verdi,Alberto,03/08/1987;
```

The number 2 represents the index of the column to search in (in the previous file the name) and Alberto represents the search key.

The output of the command must be the corresponding line, in our case: 

```
3, Verdi, Alberto,03/08/1987;
```
### Test Results (Currently In Progress)

> Using XUnit

`$ dotnet test`

