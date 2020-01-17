#Marcha de SS
use_bpm 150

#Piano
in_thread do
  use_synth :piano
  'Ba gera'
  play [:A2, :A3], release:1.5
  sleep 1.5
  play [:A2, :A3], release:0.5
  sleep 0.5
  play [:A2, :A3], release:1
  sleep 6
  'Gu ere bai'
  play [:A2, :A3], release:1.5
  sleep 1.5
  play [:A2, :A3], release:0.5
  sleep 0.5
  play [:B2, :B3], release:1
  sleep 4
  'Gu beti pozez'
  play [:G3, :B3], release:0.5
  sleep 0.5
  play [:G3, :A3, :CS4], release:1
  sleep 1
  play [:FS3, :A3, :D4], release:1
  sleep 1
  play [:FS3, :CS4], release:1
  sleep 1
  play [:FS3, :A3], release:1
  sleep 2
  'beti alai'
  play [:G3, :A3], release:1
  sleep 1
  play [:G3, :A3], release:1
  sleep 1
  play [:G3, :A3, :CS4], release:1
  sleep 1
  play [:G3, :A3, :E4], release:1
  sleep 1
  play [:FS3, :B3, :D4], release:1
  sleep 1
  'Beti alai'
  sleep 0.75
  play [:FS3, :B3, :D4], release:0.25
  sleep 0.25
  play [:FS3, :B3, :D4], release:0.5
  sleep 1
end

#Low piano

#Drums
'Ba gera'
sleep 4
sample :drum_tom_lo_soft
sleep 2
sample :drum_tom_lo_soft
sleep 5
'Gu ere bai, gu beti pozez'
sample :drum_tom_lo_soft
sleep 2
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1.5
'beti alai, beti alai'
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1
sample :drum_tom_lo_soft
sleep 1.75
sample :drum_tom_lo_soft
sleep 0.25
sample :drum_tom_lo_soft
sleep 1