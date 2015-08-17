/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {

    grunt.initConfig({
        concat: {
            options: {
            },
            dist: {
                // the files to concatenate
                src: ['app/app.js','app/**/*.js'],
                // the location of the resulting JS file
                dest: 'scripts/combined.js'
            }
        },
        jshint: {
            files: ['Gruntfile.js', 'app/**/*.js'],
            options: {
                globals: {
                    jQuery: true
                }
            }
        },
        watch: {
            files: ['<%= jshint.files %>'],
            tasks: ['jshint', 'concat']
        },
        wiredep: {

            task: {

                // Point to the files that should be updated when
                // you run `grunt wiredep`
                src: [
                  'index.html'   // .html support...
                  //'app/views/**/*.jade',   // .jade support...
                  //'app/styles/main.scss',  // .scss & .sass support...
                  //'app/config.yml'         // and .yml & .yaml support out of the box!
                ],

                options: {
                    // See wiredep's configuration documentation for the options
                    // you may pass:

                    // https://github.com/taptapship/wiredep#configuration
                }
            }
        }
    });

    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-jshint');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-wiredep');

    grunt.registerTask('default', ['jshint']);

};