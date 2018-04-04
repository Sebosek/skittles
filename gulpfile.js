'use strict';

var gulp = require('gulp'),
    sass = require('gulp-sass'),
    sourcemaps = require('gulp-sourcemaps'),
    minify = require('gulp-minify-css'),
    rename = require('gulp-rename'),
    json = require('./package.json'),
    run = require('gulp-run');

gulp.task('sass', function () {
    return gulp.src([
            './scss/**/*.scss'
        ])
        .pipe(sass().on('error', sass.logError))  
        .pipe(sourcemaps.write())
        .pipe(gulp.dest('./css'));
});

gulp.task('sass:build', function () {
    return gulp.src('./scss/**/*.scss')
        .pipe(sass().on('error', sass.logError))  
        .pipe(minify())
        .pipe(rename(`${json.name}-${json.version}#${new Date().getTime()}.min.css`))
        .pipe(gulp.dest('./css'));
});

gulp.task('sass:components', function () {
    return gulp.src('./scss/components.scss')
        .pipe(sass().on('error', sass.logError))  
        .pipe(minify())
        .pipe(rename(`skittles-components-${json.version}#${new Date().getTime()}.min.css`))
        .pipe(gulp.dest('./css'));
});

gulp.task('sass:watch', function () {
    gulp.watch('./scss/**/*.scss', ['sass']);
});

gulp.task('default', ['sass', 'sass:watch']);
