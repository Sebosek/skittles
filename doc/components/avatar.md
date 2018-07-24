# Avatar component

An avatar component is intended to visually identify a user in more reconsiable way that a simple text. Avatar component support ability to add notification badge as well as presence indication.

<div class="skittles-components-sample">
    <figure class="avatar" data-initials="SB">
    </figure>
    <figure class="avatar">
        <img src="/assets/fry.jpg">
    </figure>
</div>

```html
<figure class="avatar" data-initials="SB">
</figure>

<figure class="avatar">
    <img src="/assets/fry.jpg">
</figure>
```

## Available sizes

All sizes are defined by modifier in the order from smallest to biggest as: `avatar--extra-small`, `avatar--small`, `avatar--large` and `avatar--extra-large`.

<div class="skittles-components-sample">
    <figure class="avatar avatar--extra-small" data-initials="SB">
    </figure>
    <figure class="avatar avatar--small" data-initials="SB">
    </figure>
    <figure class="avatar" data-initials="SB">
    </figure>
    <figure class="avatar avatar--large" data-initials="SB">
    </figure>
    <figure class="avatar avatar--extra-large" data-initials="SB">
    </figure>
</div>
<div class="skittles-components-sample">
    <figure class="avatar avatar--extra-small" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar avatar--small" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar avatar--large" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar avatar--extra-large" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
</div>

```html
<figure class="avatar avatar--extra-small" data-initials="SB">
</figure>
<figure class="avatar avatar--small" data-initials="SB">
</figure>
<figure class="avatar" data-initials="SB">
</figure>
<figure class="avatar avatar--large" data-initials="SB">
</figure>
<figure class="avatar avatar--extra-large" data-initials="SB">
</figure>
```

## Presence indicators

Presence indicators comes with two API. Common API is base on modifier which are `avatar--online`, `avatar--busy` and `avatar--away`. Next to it there is also an API based on data-attributes namely `data-indication` attribute with a value corresponding with expected indication - `online`, `budy` and `away`.

<div class="skittles-components-sample">
    <figure class="avatar avatar--online" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar avatar--busy" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
    <figure class="avatar avatar--away" data-initials="SB">
        <img src="/assets/fry.jpg">
    </figure>
</div>

```html
<figure class="avatar avatar--online" data-initials="SB">
    <img src="/assets/fry.jpg">
</figure>
<figure class="avatar avatar--busy" data-initials="SB">
    <img src="/assets/fry.jpg">
</figure>
<figure class="avatar avatar--away" data-initials="SB">
    <img src="/assets/fry.jpg">
</figure>
```

## Notifications

<div class="skittles-components-sample">
    <figure class="avatar" data-initials="SB">
        <img src="/assets/fry.jpg">
        <div class="avatar__notification"></div>
    </figure>
    <figure class="avatar avatar--large" data-initials="SB">
        <img src="/assets/fry.jpg">
        <div class="avatar__notification">
            <svg class="icon"><use xlink:href="#close" /></svg>
        </div>
    </figure>
</div>

```html
<figure class="avatar" data-initials="SB">
    <img src="/assets/fry.jpg">
    <div class="avatar__notification"></div>
</figure>
<figure class="avatar avatar--large" data-initials="SB">
    <img src="/assets/fry.jpg">
    <div class="avatar__notification">
        <svg class="icon"><use xlink:href="#close" /></svg>
    </div>
</figure>
```