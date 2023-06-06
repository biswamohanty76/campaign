<template>
    <div class="blog">
        <div class="blog-header">
            <h1>My Blog</h1>
            <p>Welcome to my blog!</p>
        </div>
        <div class="blog-posts">
            <div class="blog-post">
                <img src="https://picsum.photos/800/400?random=1" alt="Sample Blog Image">
                <h2>Blog Post Title 1</h2>
                <p>Welcome to our website! We are a team of dedicated professionals who are committed to providing top-notch
                    services to our clients. Our goal is to deliver high-quality work that exceeds our clients'
                    expectations.

                    We have been in the industry for several years and have built a solid reputation for our expertise,
                    reliability, and exceptional customer service. We pride ourselves on our ability to deliver projects on
                    time and within budget, without compromising on quality.

                    At our core, we are a team of problem-solvers who are dedicated to helping our clients achieve their
                    goals. We value integrity, honesty, and transparency, and we believe that these values are reflected in
                    the way we work. Thank you for considering us for your next project. We look forward to working with
                    you!</p>
            </div>
            <div class="blog-post">
                <img src="https://picsum.photos/800/400?random=2" alt="Sample Blog Image">
                <h2>Blog Post Title 2</h2>
                <p>Welcome to our website! We are a team of dedicated professionals who are committed to providing top-notch
                    services to our clients. Our goal is to deliver high-quality work that exceeds our clients'
                    expectations.

                    We have been in the industry for several years and have built a solid reputation for our expertise,
                    reliability, and exceptional customer service. We pride ourselves on our ability to deliver projects on
                    time and within budget, without compromising on quality.

                    At our core, we are a team of problem-solvers who are dedicated to helping our clients achieve their
                    goals. We value integrity, honesty, and transparency, and we believe that these values are reflected in
                    the way we work. Thank you for considering us for your next project. We look forward to working with
                    you!</p>
            </div>
            <div class="blog-post">
                <img src="https://picsum.photos/800/400?random=3" alt="Sample Blog Image">
                <h2>Blog Post Title 3</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum euismod ex, eget rutrum sapien
                    pulvinar at. Nam ac justo luctus, dapibus sapien vitae, commodo quam. Suspendisse potenti. Sed
                    vestibulum lacus non neque rhoncus, et commodo odio convallis. Proin bibendum enim vel ligula suscipit
                    venenatis. Donec sit amet pulvinar metus. Ut consequat consequat sapien eu malesuada.</p>
            </div>
        </div>
    </div>
</template>
  
<style>
.blog {
    max-width: 1200px;
    margin: 0 auto;
}

.blog-header {
    text-align: center;
    padding: 50px 0;
}

.blog-header h1 {
    margin-bottom: 20px;
}

.blog-posts {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    grid-gap: 20px;
}

.blog-post {
    background-color: #f5f5f5;
    border-radius: 5px;
    padding: 20px;
}

.blog-post img {
    width: 100%;
    height: auto;
    border-radius: 5px;
    margin-bottom: 10px;
}

.blog-post h2 {
    margin-top: 0;
    margin-bottom: 10px;
}

.blog-post {
    background-color: #fff;
    border: 1px solid #e0e0e0;
    border-radius: 5px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
    margin-bottom: 30px;
    overflow: hidden;
}

.blog-post img {
    width: 100%;
    height: auto;
}

.blog-post .title {
    font-size: 24px;
    font-weight: bold;
    margin: 20px;
}

.blog-post .author {
    font-size: 16px;
    color: #999;
    margin: 10px 20px;
}

.blog-post .content {
    font-size: 18px;
    line-height: 1.5;
    margin: 20px;
}

.blog-post .read-more {
    display: block;
    font-size: 16px;
    font-weight: bold;
    margin: 20px;
    text-align: right;
}</style>