# TRun

Simple Task Runner, written in C#.

Work in Progress


## Development

```
git clone git://github.com/ajlopez/TRun.git
cd TRun
```

TBD

## Usage

### Hello world

`trun.txt` file at current directory:
```
# Hello, world configuration

hello
    message "Hello, world"

default
    hello
```

Having `trun.exe` in your path, run:
```
trun
```
It executes the `default` task, that has only one subtask: `hello`

You also can run:
```
trun hello
```
to run the `hello` task.

There are predefined tasks, like `message`.

### Invoking commands

`trun.txt` file at current directory:
```
# Hello, world configuration

hello
    do
        cmd /c echo Hello, world

default
    hello
```

The predefined `do` task executes commands. If a command process returns a
non-zero return value, the task will fail.

Note that the tasks can be nested, using spaces. No tab is allowed in
configuration fiel.

## Contribution

Feel free to [file issues](https://github.com/ajlopez/TRun) and submit
[pull requests](https://github.com/ajlopez/TRun/pulls) — contributions are
welcome

If you submit a pull request, please be sure to add or update corresponding
test cases, and ensure that all test continue to pass.

