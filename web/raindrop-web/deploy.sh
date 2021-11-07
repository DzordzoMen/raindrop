#!/usr/bin/env sh
# abort on errors
set -e
# build
npm run build
# add dist to commit and push it to gh-pages branch
git add dist
git commit -m 'updating dist subtree'
git subtree push --prefix dist origin gh-pages
