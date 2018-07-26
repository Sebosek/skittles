# Input component

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input label</div>
        <div class="input__envelope">
            <input class="input__control" type="text">
            <div class="input__icon">
                <svg class="icon"><use xlink:href="#close" /></svg>
            </div>
        </div>
    </label>
</div>

```html
<label class="input">
    <div class="input__label">Input label</div>
    <div class="input__envelope">
        <input class="input__control" type="text">
        <div class="input__icon">
            <svg class="icon"><use xlink:href="#close" /></svg>
        </div>
    </div>
</label>
```

## Input with an error

<div class="skittles-components-sample">
    <label class="input input--error">
        <div class="input__label">Error label</div>
        <div class="input__envelope">
            <input class="input__control" type="text">
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#close" /></svg>
            </span>
        </div>
    </label>
</div>

```html
<label class="input input--error">
    <div class="input__label">Error label</div>
    <div class="input__envelope">
        <input class="input__control" type="text">
        <span class="input__icon">
            <svg class="icon icon--blackish"><use xlink:href="#close" /></svg>
        </span>
    </div>
</label>
```

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Label with messages</div>
        <div class="input__envelope">
            <input class="input__control" type="text">
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#close" /></svg>
            </span>
        </div>
        <div class="input__messages">
            <div class="input__message">I am a info message</div>
            <div class="input__message input__message--success">Hello I am a success message</div>
            <div class="input__message input__message--error">Hello I am a error message</div>
        </div>
    </label>
</div>

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input with icons</div>
        <div class="input__envelope">
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#ghost" /></svg>
            </span>
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#gamepad" /></svg>
            </span>
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#heart" /></svg>
            </span>
            <input class="input__control" type="text">
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#close" /></svg>
            </span>
        </div>
    </label>
</div>

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input with swing</div>
        <div class="input__envelope">
            <input class="input__control" type="text">
            <span class="input__icon">
                <svg class="icon icon--blackish"><use xlink:href="#close" /></svg>
            </span>
            <div class="input__swing"></div>
        </div>
    </label>
</div>

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input with addons</div>
        <div class="input__envelope">
            <div class="input__addon">Addon</div>
            <input class="input__control" type="text">
            <div class="input__icon">
                <svg class="icon"><use xlink:href="#close" /></svg>
            </div>
            <div class="input__addon">Addon</div>
        </div>
    </label>
</div>

<div class="skittles-components-sample">
    <label class="input">
        <div class="input__label">Input with additional action</div>
        <div class="input__envelope">
            <input class="input__control" type="text">
            <div class="input__icon">
                <svg class="icon"><use xlink:href="#close" /></svg>
            </div>
        </div>
        <div class="input__action">
            <a href="#">Add action</a>
        </div>
    </label>
</div>