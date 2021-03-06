/// <binding BeforeBuild='uglify' />
module.exports = function(grunt) {

    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package-lock.json'),
        uglify: {
            options: {
                mangle: true,
                sourceMap: true,
                sourceMapName: 'sourceMap.map'
            },
            build: {
                src: ['App/app.js', 'App/UsersController.js'],
                dest: 'App/usersChallenge.min.js'
            }
        }
    });

    grunt.file.delete('App/usersChallenge.min.js');

    // Load the plugin that provides the "uglify" task.
    grunt.loadNpmTasks('grunt-contrib-uglify');

    // Default task(s).
    grunt.registerTask('default', ['uglify']);
  
  };