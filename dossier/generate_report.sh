#! /usr/bin/bash
#
# Author: Bert Van Vreckem <bert.vanvreckem@gmail.com>
#
# Genereer projectdossier. Dit script gaat uit van enkele veronderstellingen:
# 
# 1/ De nodige software moet geïnstalleerd zijn:
#
#   - LaTeX met LuaLaTeX
#   - Pandoc (http://johnmacfarlane.net/pandoc/)
#
# 2/ Een vaste mappenstructuur. Elke deelopdracht heeft een map, en ook de
# weekrapporten. Binnen elke map zitten de documenten alfabetisch in de
# volgorde waarin ze in het rapport moeten komen. Dit kan je verkrijgen door
# de bestanden te nummeren. Vermijd spaties in bestandsnamen.
#
# .
# ├── deelopdracht01
# │   ├── 01-opgave.md
# │   ├── 02-lastenboek.md
# │   ├── 03-deliverable-01.md
# │   ├── 04-deliverable-01.md
# │   ├── 05-testplan.md
# │   └── 06-testrapport.md
# ├── deelopdracht02
# │   └── ...
# ├── deelopdracht ...
# ├── weekrapport
# │   ├── week01.md
# │   ├── week02.md
# │   ├── ...
# │   └── week12.md
# └── README.md

set -o errexit # abort on nonzero exitstatus
set -o nounset # abort on unbound variable

#{{{ Functions

usage() {
cat << _EOF_
Usage: ${0} 

_EOF_
}

#}}}
#{{{ Variables

sources=$(find .. -type f -name '*.md' | fgrep -v 'TODO.md' | fgrep -v 'weeknn.md')
output=projectdossier.pdf
#}}}

# Script proper


pandoc \
  --variable mainfont="DejaVu Sans" \
  --variable monofont="DejaVu Sans Mono" \
  --variable fontsize=11pt \
  --variable geometry:margin=1.5cm \
  --variable geometry:a4paper \
  --table-of-contents \
  --number-sections \
  --latex-engine=lualatex \
  -o "${output}" \
  -f markdown  ${sources}
