/// <vs SolutionOpened='watch-sass' />
var gulp = require('gulp');
var sass = require('gulp-sass');

var files = './Content/**/*.scss*';
var output = './Content';
var source = './Content';

var sassOptions = {
    errLogToConsole: true,
    outputStyle: 'expanded',
    includePaths: [source]
};

// A display error function, to format and make custom errors more uniform
// Could be combined with gulp-util or npm colors for nicer output
var displayError = function (error) {

    // Initial building up of the error
    var errorString = '[' + error.plugin + ']';
    errorString += ' ' + error.message.replace("\n", ''); // Removes new line at the end

    // If the error contains the filename or line number add it to the string
    if (error.fileName)
        errorString += ' in ' + error.fileName;

    if (error.lineNumber)
        errorString += ' on line ' + error.lineNumber;

    // This will output an error like the following:
    // [gulp-sass] error message in file_name on line 1
    console.error(errorString);
}

gulp.task('sass-compile', function () {
    return gulp
        // Find all `.scss` files from the `Content/` folder
        .src(files)
        // Run Sass on those files
        .pipe(sass(sassOptions).on('error', function (err) {
            displayError(err);
        }))
        // Write the resulting CSS in the output folder
        .pipe(gulp.dest(output));
});

gulp.task('watch-sass', function () {
    return gulp
        // Watch the input folder for change,
        // and run `sass` task when something happens
        .watch(files, ['sass-compile'])
        // When there is a change,
        // log a message in the console
        .on('change', function(event) {
            console.log('File ' + event.path + ' was ' + event.type + ', running tasks...');
        });
});