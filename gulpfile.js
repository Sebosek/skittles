'use strict';

var gulp = require('gulp'),
    sass = require('gulp-sass'),
    copy = require('gulp-copy'),
    sourcemaps = require('gulp-sourcemaps'),
    minify = require('gulp-minify-css'),
    rename = require('gulp-rename'),
    json = require('./package.json'),
    run = require('gulp-run-command').default;

const SRC_BASE = './src/scss',
      SRC_ALL = `${SRC_BASE}/**/*.scss`,
      SRC_COMPONENTS = `${SRC_BASE}/components.scss`,
      DEST = './build/css';

gulp.task('sass', function () {
    return gulp.src([SRC_ALL])
        .pipe(sass().on('error', sass.logError))  
        .pipe(sourcemaps.write())
        .pipe(gulp.dest(DEST));
});

gulp.task('sass:build', function () {
    return gulp.src(SRC_ALL)
        .pipe(sass().on('error', sass.logError))  
        .pipe(minify())
        .pipe(rename(`${json.name}-${json.version}.min.css`))
        .pipe(gulp.dest(DEST));
});

gulp.task('sass:components', function () {
    return gulp.src(SRC_COMPONENTS)
        .pipe(sass().on('error', sass.logError))  
        .pipe(minify())
        .pipe(rename(`skittles-components-${json.version}#${new Date().getTime()}.min.css`))
        .pipe(gulp.dest(DEST));
});

gulp.task('sass:watch', function () {
    gulp.watch(SRC_ALL, ['sass']);
});

gulp.task('doc:assets', function() {
    return gulp.src(['assets/highlight.pack.js', 'assets/styles/atom-one-dark.css'])
        .pipe(copy('./build', {prefix:2}));
});

gulp.task('doc:run', run('dotnet run --project src\\doc\\Skittles.csproj'));

gulp.task('prototype:serve', run('http-server ./ -o http://localhost:8080/src/prototype/index.html'));

gulp.task('doc', ['sass', 'doc:assets', 'doc:run']);
gulp.task('prototype', ['sass', 'prototype:serve']);


gulp.task('default', ['sass', 'sass:watch']);
