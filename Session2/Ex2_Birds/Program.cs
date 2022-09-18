// See https://aka.ms/new-console-template for more information

using Ex2_Birds;

Bird bird = new Bird();
BirdWatcher birdWatcher = new BirdWatcher();
var blindBirdWatcher = new BlindBirdWatcher();
var deafBirdWatcher = new DeafBirdWatcher();

bird.BirdDelegate+=birdWatcher.ReactToBird;
bird.BirdDelegate += blindBirdWatcher.ReactToBird;
bird.BirdDelegate += deafBirdWatcher.ReactToBird;

bird.BirdAction();