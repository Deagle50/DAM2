#Steady as she goes, The Raconteurs
#DRUMS
use_bpm 124

in_thread do
  sleep 1
  sample :drum_snare_soft
  sleep 1
  7.times do
    sample :drum_cymbal_closed
    sleep 1
    sample :drum_cymbal_closed
    sample :drum_snare_soft
    sleep 1
  end
  
  8.times do
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1.5
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1.5
    sample :drum_heavy_kick, release:0.25
    sample :drum_cymbal_closed, release:0.25
    sleep 0.5
  end
  '11'
  4.times do
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1
    sample :drum_snare_soft
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_heavy_kick
    sleep 0.5
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1
    sample :drum_snare_soft, release: 0.5
    sample :drum_cymbal_closed, release: 0.5
    sleep 1
  end
  '13'
  5.times do
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1
    sample :drum_snare_soft
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_heavy_kick
    sleep 0.5
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_snare_soft, release: 0.5
    sample :drum_cymbal_closed, release: 0.5
    sleep 0.5
    sample :drum_cymbal_open
    sleep 0.5
    sample :drum_cymbal_pedal
    sleep 0.5
  end
  '18'
  sample :drum_heavy_kick
  sample :drum_cymbal_closed
  sleep 1
  sample :drum_snare_soft
  sample :drum_cymbal_closed
  sleep 0.5
  sample :drum_heavy_kick
  sleep 0.5
  sample :drum_snare_soft
  sample :drum_cymbal_closed
  sleep 0.5
  sample :drum_heavy_kick
  sleep 0.5
  sample :drum_snare_soft
  0.25
  sample :drum_snare_soft
  0.25
  sample :drum_heavy_kick
  0.5
  '19'
  4.times do
    sample :drum_cymbal_soft
    sample :drum_heavy_kick
    sleep 1
    sample :drum_snare_soft, release:0.5
    sample :drum_cymbal_soft, release:0.5
    sleep 0.75
    sample :drum_snare_soft, release:0.25
    sleep 0.25
    sample :drum_heavy_kick, release:0.50
    sample :drum_cymbal_soft, release:0.5
    sleep 0.5
    sample :drum_heavy_kick, release:0.5
    sleep 0.5
    sample :drum_snare_soft, release:0.50
    sample :drum_cymbal_soft, release:0.5
    sleep 0.5
    sample :drum_heavy_kick, release:0.5
    sleep 0.5
  end
  '23'
  
  7.times do
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 1
    sample :drum_snare_soft
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_heavy_kick
    sleep 0.5
    sample :drum_heavy_kick
    sample :drum_cymbal_closed
    sleep 0.5
    sample :drum_snare_soft, release: 0.5
    sample :drum_cymbal_closed, release: 0.5
    sleep 0.5
    sample :drum_cymbal_open
    sleep 0.5
    sample :drum_cymbal_pedal
    sleep 0.5
  end
  sample :drum_heavy_kick
  sample :drum_cymbal_closed
  sleep 1
  sample :drum_snare_soft
  sample :drum_cymbal_closed
  sleep 0.5
  sample :drum_heavy_kick
  sleep 0.5
  sample :drum_snare_soft
  sample :drum_cymbal_closed
  sleep 0.5
  sample :drum_heavy_kick
  sleep 0.5
  sample :drum_snare_soft
  0.25
  sample :drum_snare_soft
  0.25
  sample :drum_heavy_kick
  0.5
  '31th compass'
  3.times do
    sample :drum_cymbal_soft
    sample :drum_heavy_kick
    sleep 1
    sample :drum_snare_soft, release:0.5
    sample :drum_cymbal_soft, release:0.5
    sleep 0.75
    sample :drum_snare_soft, release:0.25
    sleep 0.25
    sample :drum_heavy_kick, release:0.50
    sample :drum_cymbal_soft, release:0.5
    sleep 0.5
    sample :drum_heavy_kick, release:0.5
    sleep 0.5
    sample :drum_snare_soft, release:0.50
    sample :drum_cymbal_soft, release:0.5
    sleep 0.5
    sample :drum_heavy_kick, release:0.5
    sleep 0.5
  end
  
  'Insert 34th compass'
  
  '35'
  
end
#BASS
in_thread do
  sleep 16
  use_synth :fm #:dark_ambience #:tb303
  6.times do
    play :B1, release:1
    sleep 1.5
    play :As1, release:0.5
    sleep 0.5
    play :Fs1, release:1
    sleep 1.5
    play :Fs1, release:0.5
    sleep 0.5
    play :A1, release:1
    sleep 1.5
    play :Gs1, release:0.5
    sleep 0.5
    play :E1, release:1
    sleep 1
    play :Fs1, release:1
    sleep 1
  end
  'Compas 11V2'
  2.times do
    play :B1, release:1
    sleep 1.5
    play :As1, release:0.5
    sleep 0.5
    play :Fs1, release:1
    sleep 1.5
    play :Fs1, release:0.5
    sleep 0.5
    play :A1, release:1
    sleep 1.5
    play :Gs1, release:0.5
    sleep 0.5
    play :E1, release:1
    sleep 1
    play :Fs1, release:1
    sleep 1
    
    play :B1, release:1
    sleep 1.5
    play :As1, release:0.5
    sleep 0.5
    play :Fs1, release:1
    sleep 1.5
    play :Fs1, release:0.5
    sleep 0.5
    play :A1, release:1
    sleep 1.5
    play :A1, release:0.5
    sleep 0.5
    play :FS2, release:0.5
    sleep 0.5
    play :E2, release:0.5
    sleep 0.5
    play :D2, release:0.5
    sleep 0.5
    play :CS1, release:0.5
    sleep 0.5
  end
  'Verse 1'
end

#GUITAR (Didn't find guitar sound)
in_thread do
  use_synth :piano
  sleep 32
  play :D5, release:1
  sleep 2
  play :D5, release:1
  sleep 2
  play :CS5, release:1
  sleep 2
  play :B4, release:1
  sleep 2
  
  play :D5, release:1
  sleep 2
  play :D5, release:1
  sleep 2
  play :CS5, release:1
  sleep 2
  play :B4, release:1
  sleep 2
  
  2.times do
    sleep 1
    play [:FS1, :B2, :FS2, :B2], release:1
    sleep 2
    play [:FS1, :CS2, :FS2], release:1
    sleep 2
    play chord(:A1, :major), release:1
    sleep 2
    play chord(:E1, :major), release:1
    sleep 1
  end
  
  2.times do
    sleep 1
    play [:FS1, :B2, :FS2, :B2], release:1
    sleep 1.5
    play [:FS1, :CS2, :FS2], release:0.5
    sleep 0.5
    sleep 1
    sleep 1
    play chord(:A1, :major), release:1
    sleep 1.5
    play chord(:E1, :major), release:0.5
    sleep 1.5
  end
  
  '17th compass'
end